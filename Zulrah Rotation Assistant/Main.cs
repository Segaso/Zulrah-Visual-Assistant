using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private MapRenderEngine MainMap;
        private Zulrah Boss;
        private SpeechSynthesizer SpeechSynth = new SpeechSynthesizer();
        private SpeechRecognitionEngine SpeechEngine;

        private bool SpeechOn = true;

        public Main() {
            InitializeComponent();
            MainMap = new MapRenderEngine(Canvas.Height, Canvas.Width);

            Canvas.BackgroundImage = MainMap.GetBitmap();

            Boss = new Zulrah();
            Boss.InitialPhase();
            var PossiblePhases = Boss.PossiblePhases(StyleType.Passive);

            if(PossiblePhases.Count > 1) {
                ShowPhaseDisplay(PossiblePhases);
            }

            /*
            MapEngine.ShowElement(Phase.MapBossLocation, Phase.GetPhaseColor());
            MapEngine.ShowElement(Phase.MapPlayerLocation, System.Drawing.Color.Purple);
            Canvas.BackgroundImage = MapEngine.GetBitmap();
            */

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
            MainMap.AdjustMapSize(Canvas.Height, Canvas.Width);
            Canvas.BackgroundImage = MainMap.GetBitmap();
        }

        private void btnNextPhase_Click(object sender, System.EventArgs e) {
            var Phase = Boss.NextPhase();
            var Previous = Boss.PreviousPhase;

            MainMap.HideElement(Previous.MapBossLocation);
            MainMap.HideElement(Previous.MapPlayerLocation);
            MainMap.ShowElement(Phase.MapBossLocation, Phase.GetPhaseColor());
            MainMap.ShowElement(Phase.MapPlayerLocation, System.Drawing.Color.Purple);

            Canvas.BackgroundImage = MainMap.GetBitmap();
            System.Console.Beep();
        }

        private void ShowPhaseDisplay(List<Zulrah.Phase> Phases) {
            var PossiblePhaseDisplay = new TableLayoutPanel() {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top
        };
            PossiblePhaseDisplay.Margin = new Padding(0);

            PossiblePhaseDisplay.RowCount++;
            PossiblePhaseDisplay.RowStyles.Add(new RowStyle() {
                SizeType = SizeType.AutoSize
            });

            for(int i = 0; i < Phases.Count; i++) {
                PossiblePhaseDisplay.ColumnCount++;
                PossiblePhaseDisplay.ColumnStyles.Add(new ColumnStyle() {
                    SizeType = SizeType.Percent,
                    Width = Convert.ToSingle(1.0 / Phases.Count)
                });

                var PhaseImage = new Panel() {
                    Dock = DockStyle.Fill,
                    BorderStyle = BorderStyle.Fixed3D
                };

                var PhaseMap = new MapRenderEngine(PhaseImage.Height, PhaseImage.Width);

                PhaseMap.ShowElement(Phases[i].MapBossLocation, Phases[i].GetPhaseColor());
                PhaseMap.ShowElement(Phases[i].MapPlayerLocation, System.Drawing.Color.Purple);

                PhaseImage.BackgroundImage = PhaseMap.GetBitmap();

                PossiblePhaseDisplay.Controls.Add(PhaseImage, i, 0);
            }

            Layout.RowCount++;
            Layout.RowStyles.Insert(0, new RowStyle() {
                SizeType = SizeType.Percent,
                Height = 30
            });

            Layout.Controls.Add(PossiblePhaseDisplay, 0, 0);
        }
    }
}
