using System.Drawing;
using Svg;
using System.Windows.Forms;
using System.Linq;

namespace Zulrah_Rotation_Assistant {
    /// <summary>
    /// Class containg code for manipulating SVG graphics.
    /// </summary>
    public class MapRenderEngine {

        //Allow the map to be oriented in either direction
        private bool FlipMap;
        private SvgDocument Map;
        private static Color PlayerColor = Color.Purple;
        
        public MapRenderEngine(ref Panel Canvas, bool RotateMapOrientation = false) {
            Map = SvgDocument.Open("ZulrahMap.svg");
            Map.Height = Canvas.Height;
            Map.Width = Canvas.Width;
            FlipMap = RotateMapOrientation;

            var Island = Map.GetElementById("ZulrahIsland");
            Island.Fill = new SvgColourServer(Color.White);

            Canvas.SizeChanged += Canvas_SizeChanged;
        }

        private void Canvas_SizeChanged(object sender, System.EventArgs e) {
            var Canvas = (Panel)sender;

            Map.Height = Map.Height = Canvas.Height;
            Map.Width = Canvas.Width;

            Canvas.BackgroundImage = GetBitmap();
        }

        public Bitmap GetBitmap() {
            Bitmap MapImage;
            MapImage = Map.Draw();

            if (FlipMap) {
                MapImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
            return MapImage;
        }

        public void ShowPhase(Zulrah.Phase Phase) {

            var BossObject = Map.GetElementById(Phase.MapBossLocation);
            var PlayerObject = Map.GetElementById(Phase.MapPlayerLocation);

            BossObject.FillOpacity = 255;
            PlayerObject.FillOpacity = 255;

            PlayerObject.Fill = new SvgColourServer(PlayerColor);
            BossObject.Fill = new SvgColourServer(Phase.GetPhaseColor());
        }



        public void ShowElement(string Element, Color FillColor) {
      

            var MapObject = Map.GetElementById(Element);

            MapObject.FillOpacity = 255;
            MapObject.Fill = new SvgColourServer(FillColor);
        }

        public void HideElement(string Element) {
            var MapObject = Map.GetElementById(Element);
            MapObject.FillOpacity = 0;
        }

        /// <summary>
        /// Makes sure that the image does not exceed the maximum size, while preserving aspect ratio.
        /// </summary>
        public void AdjustMapSize(int Height, int Width) {
            Map.Height = Height;
            Map.Width = Width;
        }
    }
}