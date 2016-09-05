using System.Drawing;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Zulrah_Rotation_Assistant.Properties;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {
        public class Phase {
            [JsonProperty("Boss_Location")] [JsonConverter(typeof(StringEnumConverter))] public BossLocationType
                BossLocation;


            [JsonProperty("Jad_Style", NullValueHandling = NullValueHandling.Ignore)] [JsonConverter(typeof(StringEnumConverter))] public StyleType? JadStyle;

            [JsonProperty("Notes")] public string Notes;

            [JsonProperty("Player_Location")] [JsonConverter(typeof(StringEnumConverter))] public PlayerLocationType
                PlayerLocation;

            [JsonProperty("Style")] [JsonConverter(typeof(StringEnumConverter))] public StyleType Style;

            public string MapBossLocation => $"BP_{BossLocation}";
            public string MapPlayerLocation => $"PP_{PlayerLocation}";

            public Color GetPhaseColor() {
                return GetPhaseColor(Style);
            }

            public Color GetPhaseColor(StyleType? attackStyle) {
                var colorEquvilent = new Color();
                switch (attackStyle) {
                    case StyleType.Mage:
                        colorEquvilent = Settings.Default.MageColor;
                        break;
                    case StyleType.Ranged:
                        colorEquvilent = Settings.Default.RangeColor;
                        break;
                    case StyleType.Melee:
                        colorEquvilent = Settings.Default.MeleeColor;
                        break;
                    case StyleType.Passive:
                        colorEquvilent = Settings.Default.PassiveColor;
                        break;
                    case StyleType.Jad:
                        colorEquvilent = Settings.Default.JadColor;
                        break;
                }
                return colorEquvilent;
            }

            public string GetBossLocation() {
                string locationSpeech = string.Empty;
                switch (BossLocation) {
                    case BossLocationType.N:
                        locationSpeech = "Top";
                        break;
                    case BossLocationType.S:
                        locationSpeech = "Middle";
                        break;
                    case BossLocationType.W:
                        locationSpeech = "Left";
                        break;
                    case BossLocationType.E:
                        locationSpeech = "Right";
                        break;
                }
                return locationSpeech;
            }

            public string GetNotes() {
                return $"Style {Style} Position {GetBossLocation()} ";
            }
        }
    }
}