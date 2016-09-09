using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Zulrah_Rotation_Assistant.Properties;

namespace Zulrah_Rotation_Assistant {
    public class VoiceCommandEngine {
        private static VoiceCommandEngine _instance;
        private readonly SpeechSynthesizer _speechSynthesizer;
        private bool _voicePaused;
        private static readonly  CultureInfo Language = Settings.Default.VoiceCommandLanguage;
        private SpeechRecognitionEngine _srEngine = new SpeechRecognitionEngine(Language);

        private Grammar _generalChoices;
        private Grammar _styleChoices;
        private Grammar _positionChoices;
        private Grammar _nextChoice;

        private VoiceCommandEngine() {
            try {
                _srEngine.SetInputToDefaultAudioDevice();
                _srEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;

                Zulrah.Instance.OnPhaseChanged += BossPhaseChanged;
                Zulrah.Instance.OnPhaseDecisionRequired += BossPhaseInputRequired;

                _speechSynthesizer = new SpeechSynthesizer {Rate = 4};

                string[] generalCommands = {
                    Settings.Default.ResetVoiceCommand,
                    Settings.Default.ResumeVoiceCommand,
                    Settings.Default.PauseVoiceCommand
                };


                string[] styleCommands = {
                    Settings.Default.MeleeVoiceCommand,
                    Settings.Default.MageVoiceCommand,
                    Settings.Default.RangeVoiceCommand
                };

                string[] positionCommands = {
                    Settings.Default.NorthPositionVoiceCommand,
                    Settings.Default.SouthPositionVoiceCommand,
                    Settings.Default.WestPositionVoiceCommand,
                    Settings.Default.EastPositionVoiceCommand
                };

                string nextCommand = Settings.Default.NextVoiceCommand;

                _generalChoices = new Grammar(new Choices(generalCommands).ToGrammarBuilder()) { Name = "General" };
                _styleChoices = new Grammar(new Choices(styleCommands).ToGrammarBuilder()) {Name = "StyleChoice"};
                _positionChoices = new Grammar(new Choices(positionCommands).ToGrammarBuilder()) { Name = "LocationChoice", Enabled = false};
                _nextChoice = new Grammar(new Choices(nextCommand).ToGrammarBuilder()) { Name = "NextChoice", Enabled = false };

                _srEngine.LoadGrammarAsync(_generalChoices);
                _srEngine.LoadGrammarAsync(_styleChoices);
                _srEngine.LoadGrammarAsync(_positionChoices);
                _srEngine.LoadGrammarAsync(_nextChoice);

                _srEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch {
                MessageBox.Show("Program Will Not Function, No Microphone Found");
            }
        }

        public static VoiceCommandEngine Instance => _instance ?? (_instance = new VoiceCommandEngine());

        private void BossPhaseInputRequired(IList<Zulrah.Phase> phases, bool sameAttackStyle) {
            _srEngine.Grammars[_srEngine.Grammars.IndexOf(_nextChoice)].Enabled = false;
            var statement = string.Empty;

            if (!sameAttackStyle)
                for (var i = 0; i < phases.Count; i++) {
                    if (phases.Count - 1 == i) statement += "or";
                    statement += phases[i].Style;

                    _srEngine.Grammars[_srEngine.Grammars.IndexOf(_styleChoices)].Enabled = true;
                    _srEngine.Grammars[_srEngine.Grammars.IndexOf(_positionChoices)].Enabled = false;
                }
            else
                for (var i = 0; i < phases.Count; i++) {
                    if (phases.Count - 1 == i) statement += "or";
                    statement += phases[i].GetBossLocation();

                    _srEngine.Grammars[_srEngine.Grammars.IndexOf(_styleChoices)].Enabled = false;
                    _srEngine.Grammars[_srEngine.Grammars.IndexOf(_positionChoices)].Enabled = true;
                }

            _speechSynthesizer.SpeakAsync($"Input Required: {statement}");
        }

        private void BossPhaseChanged(Zulrah.Rotation rotation) {
            _srEngine.Grammars[_srEngine.Grammars.IndexOf(_styleChoices)].Enabled = false;
            _srEngine.Grammars[_srEngine.Grammars.IndexOf(_positionChoices)].Enabled = false;
            _srEngine.Grammars[_srEngine.Grammars.IndexOf(_nextChoice)].Enabled = true;


            _speechSynthesizer.SpeakAsync(rotation.CurrentPhase.GetNotes());

            if (rotation.PlayerLocationMoved) _speechSynthesizer.SpeakAsync("Player Location Moved");

            if (rotation.CurrentPhase.JadStyle.HasValue)
                _speechSynthesizer.SpeakAsync($"Jad Phase {rotation.CurrentPhase.JadStyle} ");
        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            var voiceCommand = e.Result.Text;
            var confidence = e.Result.Confidence;
            if (confidence > .85) {
                if (_voicePaused && (voiceCommand == Settings.Default.ResumeVoiceCommand)) ResumeVoiceCommands();
                else if (!_voicePaused && (voiceCommand == Settings.Default.PauseVoiceCommand)) PauseVoiceCommands();

                if (!((!_voicePaused))) return;
                if (voiceCommand == Settings.Default.NextVoiceCommand) Zulrah.Instance.NextPhase();
                else if (voiceCommand == Settings.Default.ResetVoiceCommand) Zulrah.Instance.Reset();
                else if (voiceCommand == Settings.Default.MageVoiceCommand)
                    Zulrah.Instance.NextPhaseByStyle(Zulrah.StyleType.Mage);
                else if (voiceCommand == Settings.Default.MeleeVoiceCommand)
                    Zulrah.Instance.NextPhaseByStyle(Zulrah.StyleType.Melee);
                else if (voiceCommand == Settings.Default.RangeVoiceCommand)
                    Zulrah.Instance.NextPhaseByStyle(Zulrah.StyleType.Ranged);
                else if (voiceCommand == Settings.Default.NorthPositionVoiceCommand)
                    Zulrah.Instance.NextPhaseByLocation(Zulrah.BossLocationType.N);
                else if (voiceCommand == Settings.Default.SouthPositionVoiceCommand)
                    Zulrah.Instance.NextPhaseByLocation(Zulrah.BossLocationType.S);
                else if (voiceCommand == Settings.Default.WestPositionVoiceCommand)
                    Zulrah.Instance.NextPhaseByLocation(Zulrah.BossLocationType.W);
                else if (voiceCommand == Settings.Default.EastPositionVoiceCommand)
                    Zulrah.Instance.NextPhaseByLocation(Zulrah.BossLocationType.E);
            }
        }

        public void PauseVoiceCommands() => _voicePaused = true;
        public void ResumeVoiceCommands() => _voicePaused = false;
    }
}