using System.Windows.Forms;

namespace Zulrah_Rotation_Assistant {
    public class CustomPanel : Panel {
        public CustomPanel() : base() {
            //Prevent Flickering on Resizing
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.BackgroundImageLayout = ImageLayout.Center;
            this.Dock = DockStyle.Fill;
        }
    }
}
