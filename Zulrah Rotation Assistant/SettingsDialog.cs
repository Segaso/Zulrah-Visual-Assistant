using System;
using System.Windows.Forms;
using Zulrah_Rotation_Assistant.Properties;

namespace Zulrah_Rotation_Assistant {
    public partial class SettingsDialog : Form {
        public SettingsDialog() {
            InitializeComponent();
            VoiceCommandEngine.Instance.PauseVoiceCommands();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Settings.Default.Save();
            Application.Restart();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void pnColor_MouseClick(object sender, MouseEventArgs e) {
            var panel = (Panel) sender;

            var colorDialog = new ColorDialog {
                AllowFullOpen = true,
                AnyColor = true,
                Color = panel.BackColor,
                FullOpen = true
            };

            var result = colorDialog.ShowDialog();

            if (result == DialogResult.OK) panel.BackColor = colorDialog.Color;
        }

        private void SettingsDialog_FormClosed(object sender, FormClosedEventArgs e) {
            VoiceCommandEngine.Instance.ResumeVoiceCommands();
        }
    }
}