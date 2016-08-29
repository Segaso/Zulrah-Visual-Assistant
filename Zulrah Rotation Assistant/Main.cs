using System.Speech.Recognition;
using System.Globalization;
using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Speech.Synthesis;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private bool _phasesDisplayOn;
        private readonly MapRenderEngine _mainMap;
        private readonly Zulrah _boss;
        private readonly SpeechSynthesizer _speechSynthesizer;
        public Main() {
            InitializeComponent();
            _mainMap = new MapRenderEngine(ref MainCanvas);

            _boss = new Zulrah();
            _boss.InitialPhase();

            _mainMap.ShowPhase(_boss.CurrentPhase);

            try {
                _boss.NextPhase();
            } catch(InvalidOperationException) {
                var phases = _boss.PossiblePhases(_boss.CurrentPhase.Style);
                ShowPhaseDisplay(phases);
            }

            var language = new CultureInfo("en-us");

            _speechSynthesizer = new SpeechSynthesizer {Rate = 4};

            var speechEngine = new SpeechRecognitionEngine(language);
            speechEngine.SetInputToDefaultAudioDevice();
            speechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;

            var commands = new Choices();

            commands.Add("Next");
            commands.Add("Reset");
            commands.Add("Blue");
            commands.Add("Red");
            commands.Add("Green");
            commands.Add("Top");
            commands.Add("Right");

            var gramarCommands = new GrammarBuilder();
            gramarCommands.Append(commands);

            speechEngine.LoadGrammarAsync(new Grammar(gramarCommands));
            speechEngine.RecognizeAsync(RecognizeMode.Multiple);

        }

        private void NextPhase(StyleType style) {
            if (!_boss.PhaseDescisionInputRequired) {
                try {
                    _mainMap.ShowPhase(_boss.NextPhase());

                    if (_phasesDisplayOn) {
                        HidePhaseDisplay();
                    }

                } catch (InvalidOperationException) {
                    var phases = _boss.PossiblePhases(_boss.CurrentPhase.Style);
                    ShowPhaseDisplay(phases);
                }
            } else {
                _mainMap.ShowPhase(_boss.NextPhase(style));
                if (_phasesDisplayOn) {
                    HidePhaseDisplay();
                }
            }

            _speechSynthesizer.SpeakAsync(_boss.CurrentPhase.GetNotes());
        }


        private void NextPhase(BossLocationType bossLocation) {
            if (_boss.PhaseSameAttackStyle) {
                _mainMap.ShowPhase(_boss.NextPhase(bossLocation));
                if (_phasesDisplayOn) {
                    HidePhaseDisplay();
                }
            }

            _speechSynthesizer.SpeakAsync(_boss.CurrentPhase.GetNotes());
        }

        private void HidePhaseDisplay() {
            MainLayout.Controls.Remove(MainLayout.GetControlFromPosition(0, 0));
    
            MainLayout.RowCount--;
            MainLayout.RowStyles.RemoveAt(0);

            _phasesDisplayOn = false;
        }

        private void ShowPhaseDisplay(List<Zulrah.Phase> phases) {
            var possiblePhaseDisplay = new TableLayoutPanel {
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom | AnchorStyles.Top,
                Name = "PossiblePhaseDisplay",
                Margin = new Padding(0)
            };

            possiblePhaseDisplay.RowCount++;
            possiblePhaseDisplay.RowStyles.Add(new RowStyle() {
                SizeType = SizeType.AutoSize
            });

            for(int i = 0; i < phases.Count; i++) {
                possiblePhaseDisplay.ColumnCount++;
                possiblePhaseDisplay.ColumnStyles.Add(new ColumnStyle() {
                    SizeType = SizeType.Percent,
                    Width = Convert.ToSingle(1.0 / phases.Count)
                });

                var phaseCanvas = new Panel() {
                    Dock = DockStyle.Fill,
                };

                var phaseMap = new MapRenderEngine(ref phaseCanvas);

                phaseMap.ShowPhase(phases[i]);

                possiblePhaseDisplay.Controls.Add(phaseCanvas, i, 0);
            }

            MainLayout.RowCount++;
            MainLayout.RowStyles.Insert(0, new RowStyle() {
                SizeType = SizeType.Percent,
                Height = 30
            });

            MainLayout.Controls.Add(possiblePhaseDisplay, 0, 0);

            _phasesDisplayOn = true;
        }

        private void SpeechEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e) {
            string voiceCommand = e.Result.Text;
            float confidence = e.Result.Confidence;

            if(confidence > .5)
            switch (voiceCommand) {
               case "Next":
                    NextPhase(_boss.CurrentPhase.Style);
                    break;
                case "Top":
                    NextPhase(BossLocationType.N);
                    break;
                case "Right":
                    NextPhase(BossLocationType.E);
                    break;
                case "Red":
                    NextPhase(StyleType.Melee);
                    break;
                case "Blue":
                    NextPhase(StyleType.Mage);
                    break;
                case "Green":
                    NextPhase(StyleType.Ranged);
                    break;
                case "Reset":
                    _boss.InitialPhase();

                    _mainMap.ShowPhase(_boss.CurrentPhase);

                    try {
                        _boss.NextPhase();
                    } catch (InvalidOperationException) {
                        var phases = _boss.PossiblePhases(_boss.CurrentPhase.Style);
                        if (!_phasesDisplayOn) {
                            ShowPhaseDisplay(phases);
                        }
                    }
                    break;
            }
        }
    }
}
