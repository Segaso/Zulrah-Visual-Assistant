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

            public string MapBossLocation => $"BP_{BossLocation}";
            public string MapPlayerLocation => $"PP_{PlayerLocation}";

            public Color GetPhaseColor() {
                return GetPhaseColor(Style);
            }

            public Color GetPhaseColor(StyleType attackStyle) {
                Color colorEquvilent = new Color(); 
                switch(attackStyle) {
                    case StyleType.Mage:
                        colorEquvilent = Properties.Settings.Default.MageColor;
                        break;
                    case StyleType.Ranged:
                        colorEquvilent = Properties.Settings.Default.RangeColor;
                        break;
                    case StyleType.Melee:
                        colorEquvilent = Properties.Settings.Default.MeleeColor;
                        break;
                    case StyleType.Passive:
                        colorEquvilent = Properties.Settings.Default.PassiveColor;
                        break;
                    case StyleType.Jad:
                        colorEquvilent = Properties.Settings.Default.JadColor;
                        break;
                }
                return colorEquvilent;
            }


            public string GetNotes() {
                string locationSpeech = "";
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

                return $"Boss Style {Style} Position {locationSpeech} ";
            }

        }

    }
}
