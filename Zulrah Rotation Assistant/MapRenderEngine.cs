using System.Drawing;
using Svg;
using System.Collections.Generic;

namespace Zulrah_Rotation_Assistant {
    /// <summary>
    /// Class containg code for manipulating SVG graphics.
    /// </summary>
    public class MapRenderEngine {

        //Allow the map to be oriented in either direction
        private bool FlipMap;
        private SvgDocument Map;
        
        public MapRenderEngine(int Height, int Width, bool RotateMapOrientation = false ) {
            Map = SvgDocument.Open("ZulrahMap.svg");
            Map.Height = Height;
            Map.Width = Width;
            FlipMap = RotateMapOrientation;

            var Island = Map.GetElementById("ZulrahIsland");
            Island.Fill = new SvgColourServer(Color.White);
        }

        public Bitmap GetBitmap() {
            Bitmap MapImage;
            MapImage = Map.Draw();

            if (FlipMap) {
                MapImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            }
            return MapImage;
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