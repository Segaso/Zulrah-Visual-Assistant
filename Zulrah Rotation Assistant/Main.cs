using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Windows.Forms;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private MapRenderEngine MapEngine;
        private Zulrah Boss;
        private SpeechSynthesizer SpeechSynth = new SpeechSynthesizer();
        private SpeechRecognitionEngine SpeechEngine;

        private bool SpeechOn = true;

        public Main() {
            InitializeComponent();
            MapEngine = new MapRenderEngine(Canvas.Height, Canvas.Width);

            Canvas.BackgroundImage = MapEngine.GetBitmap();

            Boss = new Zulrah();
            Boss.InitialPhase();
            Boss.PossiblePhases(StyleType.Passive);
            Boss.PossiblePhases(StyleType.Mage);


            var Phase = Boss.NextPhase();

            MapEngine.ShowElement(Phase.MapBossLocation, Phase.GetPhaseColor());
            MapEngine.ShowElement(Phase.MapPlayerLocation, System.Drawing.Color.Purple);
            Canvas.BackgroundImage = MapEngine.GetBitmap();


            /*
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
            */
        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            string txt = e.Result.Text;
            float confidence = e.Result.Confidence;


            if(SpeechOn) {

            } else {

            }
        }

        private void Canvas_Resize(object sender, System.EventArgs e) {
            MapEngine.AdjustMapSize(Canvas.Height, Canvas.Width);
            Canvas.BackgroundImage = MapEngine.GetBitmap();
        }

        private void btnNextPhase_Click(object sender, System.EventArgs e) {
            var Phase = Boss.NextPhase();
            var Previous = Boss.PreviousPhase;

            MapEngine.HideElement(Previous.MapBossLocation);
            MapEngine.HideElement(Previous.MapPlayerLocation);
            MapEngine.ShowElement(Phase.MapBossLocation, Phase.GetPhaseColor());
            MapEngine.ShowElement(Phase.MapPlayerLocation, System.Drawing.Color.Purple);

            Canvas.BackgroundImage = MapEngine.GetBitmap();
            System.Console.Beep();
        }
    }
}
