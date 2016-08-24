using System.Drawing;
using Svg;
using System.Collections.Generic;

namespace Zulrah_Rotation_Assistant {
    /// <summary>
    /// Class containg code for manipulating SVG graphics.
    /// </summary>
    public class MapRenderEngine {
        private SvgDocument Map;
        private SvgElement PreviousBossLocation;
        

        public MapRenderEngine(int Height, int Width) {
            Map = SvgDocument.Open("ZulrahMap.svg");
            Map.Height = Height;
            Map.Width = Width;

            var Island = Map.GetElementById("ZulrahIsland");
            Island.Fill = new SvgColourServer(Color.White);
        }

        public Bitmap GetBitmap() {
           return Map.Draw();
        }

        public void UpdateColor(string Element, Color FillColor) {
            var MapObject = Map.GetElementById(Element);

            MapObject.FillOpacity = 255;
            MapObject.Fill = new SvgColourServer(FillColor);
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