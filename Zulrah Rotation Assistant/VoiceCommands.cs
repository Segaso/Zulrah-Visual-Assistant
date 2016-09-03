using System.Globalization;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using Zulrah_Rotation_Assistant.Properties;

namespace Zulrah_Rotation_Assistant {
    public class VoiceCommandEngine {
        private static VoiceCommandEngine _instance;
        private readonly SpeechSynthesizer _speechSynthesizer;

        private VoiceCommandEngine() {
            var language = Settings.Default.VoiceCommandLanguage;
            var speechEngine = new SpeechRecognitionEngine(language);
            speechEngine.SetInputToDefaultAudioDevice();
            speechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;

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
                Settings.Default.NextVoiceCommand
            };

            speechEngine.LoadGrammarAsync(new Grammar(new Choices(commands).ToGrammarBuilder()));
            speechEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        public static VoiceCommandEngine Instance => _instance ?? (_instance = new VoiceCommandEngine());

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            var voiceCommand = e.Result.Text;
            var confidence = e.Result.Confidence;

            if (confidence > .5)
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
}