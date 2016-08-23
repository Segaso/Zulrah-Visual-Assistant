using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }

    }
}
