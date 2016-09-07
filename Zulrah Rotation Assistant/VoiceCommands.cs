using System.Collections.Generic;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using Zulrah_Rotation_Assistant.Properties;

namespace Zulrah_Rotation_Assistant {
    public class VoiceCommandEngine {
        private static VoiceCommandEngine _instance;
        private readonly SpeechSynthesizer _speechSynthesizer;
        private bool _voicePaused;

        private VoiceCommandEngine() {
            var language = Settings.Default.VoiceCommandLanguage;
            var speechEngine = new SpeechRecognitionEngine(language);
            try {
                speechEngine.SetInputToDefaultAudioDevice();
                speechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;

                Zulrah.Instance.OnPhaseChanged += BossPhaseChanged;
                Zulrah.Instance.OnPhaseDecisionRequired += BossPhaseInputRequired;

                _speechSynthesizer = new SpeechSynthesizer {Rate = 4};

                string[] commands = {
                    Settings.Default.MeleeVoiceCommand,
                    Settings.Default.MageVoiceCommand,
                    Settings.Default.RangeVoiceCommand,
                    Settings.Default.NorthPositionVoiceCommand,
                    Settings.Default.SouthPositionVoiceCommand,
                    Settings.Default.WestPositionVoiceCommand,
                    Settings.Default.EastPositionVoiceCommand,
                    Settings.Default.ResetVoiceCommand,
                    Settings.Default.NextVoiceCommand,
                    Settings.Default.ResumeVoiceCommand,
                    Settings.Default.PauseVoiceCommand
                };

                speechEngine.LoadGrammarAsync(new Grammar(new Choices(commands).ToGrammarBuilder()));
                speechEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch {
                MessageBox.Show("Program Will Not Function, No Microphone Found");
            }
        }

        public static VoiceCommandEngine Instance => _instance ?? (_instance = new VoiceCommandEngine());

        private void BossPhaseInputRequired(IList<Zulrah.Phase> phases, bool sameAttackStyle) {
            var statement = string.Empty;

            if (!sameAttackStyle)
                for (var i = 0; i < phases.Count; i++) {
                    if (phases.Count - 1 == i) statement += "or";
                    statement += phases[i].Style;
                }
            else
                for (var i = 0; i < phases.Count; i++) {
                    if (phases.Count - 1 == i) statement += "or";
                    statement += phases[i].GetBossLocation();
                }

            _speechSynthesizer.SpeakAsync($"Input Required: {statement}");
        }

        private void BossPhaseChanged(Zulrah.Rotation rotation) {
            _speechSynthesizer.SpeakAsync(rotation.CurrentPhase.GetNotes());

            if (rotation.PlayerLocationMoved) _speechSynthesizer.SpeakAsync("Player Location Moved");

            if (rotation.CurrentPhase.JadStyle.HasValue)
                _speechSynthesizer.SpeakAsync($"Jad Phase {rotation.CurrentPhase.JadStyle} ");
        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            var voiceCommand = e.Result.Text;
            var confidence = e.Result.Confidence;

            if (_voicePaused && (voiceCommand == Settings.Default.ResumeVoiceCommand)) ResumeVoiceCommands();
            else if (!_voicePaused && (voiceCommand == Settings.Default.PauseVoiceCommand)) PauseVoiceCommands();

            if (!((confidence > .5) && !_voicePaused)) return;
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

        public void PauseVoiceCommands() => _voicePaused = true;
        public void ResumeVoiceCommands() => _voicePaused = false;
    }
}