using System.Drawing;
using Svg;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Zulrah_Rotation_Assistant {
    /// <summary>
    /// Class containg code for manipulating SVG graphics.
    /// </summary>
    public class MapRenderEngine {

        //Allow the map to be oriented in either direction
        private bool FlipMap;
        private SvgDocument Map;
        private Panel MapCanvas;
        private List<string> PreviousElementIDs;
        private static Color PlayerColor = Color.Purple;
        private static Color MapColor = Color.FromArgb(47, 47, 48);
        
        public MapRenderEngine(ref Panel Canvas, bool RotateMapOrientation = false) {
            MapCanvas = Canvas;

            Map = SvgDocument.Open("ZulrahMap.svg");
            Map.Height = MapCanvas.Height;
            Map.Width = MapCanvas.Width;
            FlipMap = RotateMapOrientation;

            var Island = Map.GetElementById("ZulrahIsland");
            Island.Fill = new SvgColourServer(Color.White);

            MapCanvas.BackColor = MapColor;

            MapCanvas.SizeChanged += Canvas_SizeChanged;
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
            try {
                foreach (string ElementID in PreviousElementIDs) {
                    HideElement(ElementID);
                }
            }catch(NullReferenceException) {
                PreviousElementIDs = new List<string>();
            }


            PreviousElementIDs.Clear();

            var BossObject = Map.GetElementById(Phase.MapBossLocation);
            var PlayerObject = Map.GetElementById(Phase.MapPlayerLocation);

            PreviousElementIDs.Add(Phase.MapBossLocation);
            PreviousElementIDs.Add(Phase.MapPlayerLocation);
            

            BossObject.FillOpacity = 255;
            PlayerObject.FillOpacity = 255;

            PlayerObject.Fill = new SvgColourServer(PlayerColor);
            BossObject.Fill = new SvgColourServer(Phase.GetPhaseColor());

            MapCanvas.BackgroundImage = GetBitmap();
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