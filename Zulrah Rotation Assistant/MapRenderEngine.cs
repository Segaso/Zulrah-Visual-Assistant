using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using Svg;
using Zulrah_Rotation_Assistant.Properties;

namespace Zulrah_Rotation_Assistant {
    /// <summary>
    ///     Class containg code for manipulating SVG graphics.
    /// </summary>
    public class MapRenderEngine {
        private static readonly Color PlayerColor = Settings.Default.PlayerColor;
        private static readonly Color MapColor = Settings.Default.MapBackgroundColor;

        //Allow the map to be oriented in either direction
        private readonly bool _flipMap;
        private readonly SvgDocument _map;
        private readonly Panel _mapCanvas;
        private List<string> _previousElementIDs;

        public MapRenderEngine(ref Panel canvas) {
            _mapCanvas = canvas;

            var mapResource = new XmlDocument();
            mapResource.LoadXml(Resources.ZulrahMap);

            _map = SvgDocument.Open(mapResource);

            _map.Height = _mapCanvas.Height;
            _map.Width = _mapCanvas.Width;
            _flipMap = Settings.Default.MapFlipped;

            var island = _map.GetElementById("ZulrahIsland");
            island.Fill = new SvgColourServer(Settings.Default.ZulrahIsland_Color);
            island.Stroke = new SvgColourServer(Settings.Default.ZulrahIsland_BorderColor);

            _mapCanvas.BackColor = MapColor;

            _mapCanvas.SizeChanged += Canvas_SizeChanged;
        }

        private void Canvas_SizeChanged(object sender, EventArgs e) {
            var canvas = (Panel) sender;

            _map.Height = _map.Height = canvas.Height;
            _map.Width = canvas.Width;

            canvas.BackgroundImage = GetBitmap();
        }

        public Bitmap GetBitmap() {
            var mapImage = _map.Draw();

            if (_flipMap) mapImage.RotateFlip(RotateFlipType.Rotate180FlipX);
            return mapImage;
        }

        public void ShowPhase(Zulrah.Phase phase) {
            try {
                foreach (var elementId in _previousElementIDs) HideElement(elementId);
            }
            catch (NullReferenceException) {
                _previousElementIDs = new List<string>();
            }


            _previousElementIDs.Clear();

            var bossObject = _map.GetElementById(phase.MapBossLocation);
            var playerObject = _map.GetElementById(phase.MapPlayerLocation);

            _previousElementIDs.Add(phase.MapBossLocation);
            _previousElementIDs.Add(phase.MapPlayerLocation);

            if (phase.Style == Zulrah.StyleType.Jad) {
                bossObject.StrokeOpacity = 255;
                bossObject.Stroke = new SvgColourServer(phase.GetPhaseColor(phase.JadStyle));
            }
            else {
                bossObject.StrokeOpacity = 0;
            }

            bossObject.FillOpacity = 255;
            playerObject.FillOpacity = 255;

            playerObject.Fill = new SvgColourServer(PlayerColor);
            bossObject.Fill = new SvgColourServer(phase.GetPhaseColor());

            _mapCanvas.BackgroundImage = GetBitmap();
        }

        /// <summary>
        ///     Used to hide an element in the SVG map.
        ///     I.E when the Boss moves and the previous position is no longer relevant, or the player position moves.
        /// </summary>
        /// <param name="element">The ID of the element in the SVG (like PP_NE)</param>
        public void HideElement(string element) {
            var mapObject = _map.GetElementById(element);
            mapObject.FillOpacity = 0;
            mapObject.StrokeOpacity = 0;
        }

        /// <summary>
        ///     Makes sure that the image does not exceed the maximum size, while preserving aspect ratio.
        /// </summary>
        public void AdjustMapSize(int height, int width) {
            _map.Height = height;
            _map.Width = width;
        }
    }
}