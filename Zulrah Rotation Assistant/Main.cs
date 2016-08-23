using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private SpeechSynthesizer SpeechSynth = new SpeechSynthesizer();
        private SpeechRecognitionEngine SpeechEngine;

        private bool SpeechOn = true;

        public Main() {
            InitializeComponent();

            var Zulrah = new Zulrah();

            Zulrah.NextPhase(StyleType.Melee);


            SpeechSynth.SetOutputToDefaultAudioDevice();

            var Language = new CultureInfo("en-us");

            SpeechEngine = new SpeechRecognitionEngine(Language);
            SpeechEngine.SetInputToDefaultAudioDevice();
            SpeechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;

            var Commands = new Choices();

            Commands.Add("Speech Off");
            Commands.Add("Speech On");
            Commands.Add("Next");
            Commands.Add("Reset");
            Commands.Add("Blue");
            Commands.Add("Red");
            Commands.Add("Green");
            Commands.Add("Top");

            var GramarCommands = new GrammarBuilder();
            GramarCommands.Append(Commands);
   
            SpeechEngine.LoadGrammarAsync(new Grammar(GramarCommands));
            SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            string txt = e.Result.Text;
            float confidence = e.Result.Confidence;


            if(SpeechOn) {

            } else {

            }
        }
    }
}
