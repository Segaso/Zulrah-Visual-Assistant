using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Drawing;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {
        public class Phase {
            [JsonProperty("Style")]
            [JsonConverter(typeof(StringEnumConverter))]
            public StyleType Style;

            [JsonProperty("Boss_Location")]
            [JsonConverter(typeof(StringEnumConverter))]
            public BossLocationType BossLocation;

            [JsonProperty("Player_Location")]
            [JsonConverter(typeof(StringEnumConverter))]
            public PlayerLocationType PlayerLocation;

            [JsonProperty("Jad_Style")]
            public StyleType JadStyle;

            [JsonProperty("Notes")]
            public string Notes;

            public string MapBossLocation { get { return string.Format("BP_{0}", BossLocation.ToString()); } }
            public string MapPlayerLocation { get { return string.Format("PP_{0}", PlayerLocation.ToString()); } }

            public Color GetPhaseColor() {
                Color ColorEquvilent = new Color(); 
                switch(Style) {
                    case StyleType.Mage:
                        ColorEquvilent = Properties.Settings.Default.MageColor;
                        break;
                    case StyleType.Ranged:
                        ColorEquvilent = Properties.Settings.Default.RangeColor;
                        break;
                    case StyleType.Melee:
                        ColorEquvilent = Properties.Settings.Default.MeleeColor;
                        break;
                    case StyleType.Passive:
                        ColorEquvilent = Properties.Settings.Default.PassiveColor;
                        break;
                    case StyleType.Jad:
                        ColorEquvilent = Properties.Settings.Default.JadColor;
                        break;
                }
                return ColorEquvilent;
            }

        }

    }
}
