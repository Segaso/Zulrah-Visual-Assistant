using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private bool PhaseDisplayOn;
        private MapRenderEngine MainMap;
        private Zulrah Boss;
        private SpeechSynthesizer SpeechSynth = new SpeechSynthesizer();

        private bool SpeechOn = true;

        public Main() {
            InitializeComponent();
            MainMap = new MapRenderEngine(ref MainCanvas);

            Boss = new Zulrah();
            Boss.InitialPhase();
            var PossiblePhases = Boss.PossiblePhases(StyleType.Passive);

            MainMap.ShowPhase(Boss.CurrentPhase);

            if (PossiblePhases.Count > 1) {
                ShowPhaseDisplay(PossiblePhases);
            }


        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            string txt = e.Result.Text;
            float confidence = e.Result.Confidence;


            if(SpeechOn) {

            } else {

            }
        }

        private void btnNextPhase_Click(object sender, System.EventArgs e) {
            if(Boss.RotationFound) {
                if (PhaseDisplayOn) {
                    HidePhaseDisplay();
                }

                MainMap.ShowPhase(Boss.NextPhase());
            } else {
                ShowPhaseDisplay(Boss.PossiblePhases(StyleType.Ranged));
            }

        }


        private void HidePhaseDisplay() {
            Layout.Controls.Remove(Layout.GetControlFromPosition(0, 0));
    
            Layout.RowCount--;
            Layout.RowStyles.RemoveAt(0);

            PhaseDisplayOn = false;

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

            Layout.RowCount++;
            Layout.RowStyles.Insert(0, new RowStyle() {
                SizeType = SizeType.Percent,
                Height = 30
            });

            Layout.Controls.Add(PossiblePhaseDisplay, 0, 0);

            PhaseDisplayOn = true;
        }
    }
}
