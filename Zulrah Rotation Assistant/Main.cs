using System.Windows.Forms;

namespace Zulrah_Rotation_Assistant {
    public partial class Main : Form {
        private Zulrah _boss;
        private VoiceCommandEngine _voiceCommands;
        private MapRenderEngine _mainMapRenderEngine;
        public Main() {
            InitializeComponent();
            _mainMapRenderEngine = new MapRenderEngine(ref MainCanvas);
            _voiceCommands = VoiceCommandEngine.Instance;
            _boss = Zulrah.Instance;

            _boss.OnPhaseChanged += _boss_OnPhaseChanged;
            _boss.OnPhaseDecisionRequired += _boss_OnPhaseDecisionRequired;          
        }

        private void _boss_OnPhaseDecisionRequired(object sender, System.EventArgs eventArgs) {
        }

        private void _boss_OnPhaseChanged(object sender, System.EventArgs eventArgs) {
            var phase = (Zulrah.Phase)sender;
            _mainMapRenderEngine.ShowPhase(phase);
        }
    }
}
