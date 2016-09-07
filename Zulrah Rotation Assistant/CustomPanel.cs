using System.Windows.Forms;

namespace Zulrah_Rotation_Assistant {
    public sealed class CustomPanel : Panel {
        public CustomPanel() {
            //Prevent Flickering on Resizing
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.UserPaint, true);

            BackgroundImageLayout = ImageLayout.Center;
            Dock = DockStyle.Fill;
        }
    }
}