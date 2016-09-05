using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private readonly MapRenderEngine _mainMapRenderEngine;

        public Main() {
            InitializeComponent();
            _mainMapRenderEngine = new MapRenderEngine(ref MainCanvas);

            var boss = Zulrah.Instance;
            var voiceCommands = VoiceCommandEngine.Instance;

            boss.OnPhaseChanged += _boss_OnPhaseChanged;
            boss.OnPhaseDecisionRequired += _boss_OnPhaseDecisionRequired;

            boss.Start();
        }

        private bool PhaseDisplayOn => Controls.Find("PossiblePhaseDisplay", true).Length == 1;

        private void _boss_OnPhaseDecisionRequired(IList<Zulrah.Phase> phases, bool sameAttackStyle) {
            if (!PhaseDisplayOn) ShowPhaseDialog(phases.ToList());
        }

        private void ShowPhaseDialog(List<Zulrah.Phase> phases) {
            var possiblePhaseDisplay = new TableLayoutPanel {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top,
                Name = "PossiblePhaseDisplay",
                Margin = new Padding(0),
                RowCount = 1,
                RowStyles = {new RowStyle(SizeType.AutoSize)},
                ColumnCount = phases.Count
            };

            foreach (var phase in phases) {
                var phaseCanvas = new Panel {
                    Dock = DockStyle.Fill
                };

                var phaseMap = new MapRenderEngine(ref phaseCanvas);

                phaseMap.ShowPhase(phase);

                possiblePhaseDisplay.ColumnStyles.Add(new ColumnStyle {
                    SizeType = SizeType.Percent,
                    Width = Convert.ToSingle(1.0/phases.Count)
                });

                possiblePhaseDisplay.Controls.Add(phaseCanvas, phases.IndexOf(phase), 0);
            }

            MainLayout.RowCount++;
            MainLayout.RowStyles.Insert(0, new RowStyle {
                SizeType = SizeType.Percent,
                Height = 30
            });

            MainLayout.Controls.Add(possiblePhaseDisplay, 0, 0);
        }

        private void _boss_OnPhaseChanged(Zulrah.Rotation rotation) {
            _mainMapRenderEngine.ShowPhase(rotation.CurrentPhase);

            if (PhaseDisplayOn) HidePhaseDialog();
        }

        private void HidePhaseDialog() {
            MainLayout.Controls.Remove(MainLayout.GetControlFromPosition(0, 0));

            MainLayout.RowCount--;
            MainLayout.RowStyles.RemoveAt(0);
        }
    }
}