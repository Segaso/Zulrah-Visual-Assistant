using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private bool PhasesDisplayOn;
        private MapRenderEngine MainMap;
        private Zulrah Boss;
        private SpeechRecognitionEngine SpeechEngine;
        private SpeechSynthesizer SpeechSynth = new SpeechSynthesizer();

        public Main() {
            InitializeComponent();

            var Test = Properties.Settings.Default.PlayerColor;
            MainMap = new MapRenderEngine(ref MainCanvas);

            Boss = new Zulrah();
            Boss.InitialPhase();

            MainMap.ShowPhase(Boss.CurrentPhase);

            try {
                Boss.NextPhase();
            } catch(InvalidOperationException) {
                var Phases = Boss.PossiblePhases(Boss.CurrentPhase.Style);
                ShowPhaseDisplay(Phases);
            }

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

        private void btnNextPhase_Click(object sender, EventArgs e) {
        }

        private void NextPhase(StyleType Style) {
            if (!Boss.PhaseDescisionInputRequired) {
                try {
                    MainMap.ShowPhase(Boss.NextPhase());

                    if (PhasesDisplayOn) {
                        HidePhaseDisplay();
                    }

                } catch (InvalidOperationException) {
                    var Phases = Boss.PossiblePhases(Boss.CurrentPhase.Style);
                    ShowPhaseDisplay(Phases);
                }
            } else {
                MainMap.ShowPhase(Boss.NextPhase(Style));
                if (PhasesDisplayOn) {
                    HidePhaseDisplay();
                }
            }
        }


        private void NextPhase(BossLocationType Location) {
            if (Boss.PhaseSameAttackStyle) {
                MainMap.ShowPhase(Boss.NextPhase(Location));
                if (PhasesDisplayOn) {
                    HidePhaseDisplay();
                }
            }
        }

        private void HidePhaseDisplay() {
            MainLayout.Controls.Remove(MainLayout.GetControlFromPosition(0, 0));
    
            MainLayout.RowCount--;
            MainLayout.RowStyles.RemoveAt(0);

            PhasesDisplayOn = false;
        }

        private void ShowPhaseDisplay(List<Zulrah.Phase> Phases) {
            var PossiblePhaseDisplay = new TableLayoutPanel() {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top
                ,Name = "PossiblePhaseDisplay"
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

                var PhaseCanvas = new Panel() {
                    Dock = DockStyle.Fill,
                };

                var PhaseMap = new MapRenderEngine(ref PhaseCanvas);

                PhaseMap.ShowPhase(Phases[i]);

                PossiblePhaseDisplay.Controls.Add(PhaseCanvas, i, 0);
            }

            MainLayout.RowCount++;
            MainLayout.RowStyles.Insert(0, new RowStyle() {
                SizeType = SizeType.Percent,
                Height = 30
            });

            MainLayout.Controls.Add(PossiblePhaseDisplay, 0, 0);

            PhasesDisplayOn = true;
        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            string VoiceCommand = e.Result.Text;
            float confidence = e.Result.Confidence;

            switch (VoiceCommand) {
               case "Next":
                    NextPhase(Boss.CurrentPhase.Style);
                    break;
                case "Top":
                    NextPhase(BossLocationType.N);
                    break;
                case "Red":
                    NextPhase(StyleType.Melee);
                    break;
                case "Blue":
                    NextPhase(StyleType.Melee);
                    break;
                case "Green":
                    NextPhase(StyleType.Ranged);
                    break;
                case "Reset":
                    Boss.InitialPhase();

                    MainMap.ShowPhase(Boss.CurrentPhase);

                    try {
                        Boss.NextPhase();
                    } catch (InvalidOperationException) {
                        var Phases = Boss.PossiblePhases(Boss.CurrentPhase.Style);
                        if (!PhasesDisplayOn) {
                            ShowPhaseDisplay(Phases);
                        }
                    }
                    break;
            };
        }
    }
}
