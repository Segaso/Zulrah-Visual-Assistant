using System;
using System.Windows.Forms;

namespace Zulrah_Rotation_Assistant {
    public partial class SettingsDialog : Form {
        public SettingsDialog() {
            InitializeComponent();
       }

        private void btnSave_Click(object sender, EventArgs e) {
            Properties.Settings.Default.Save();
            Application.Restart();
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void pnColor_MouseClick(object sender, MouseEventArgs e) {
            var panel = (Panel)sender;

            var ColorDialog = new ColorDialog {
                AllowFullOpen = true,
                AnyColor = true,
                Color = panel.BackColor,
                FullOpen = true
            };

            var Result = ColorDialog.ShowDialog();

            if(Result == DialogResult.OK) {
                panel.BackColor = ColorDialog.Color;
            }
        }
    }
}
