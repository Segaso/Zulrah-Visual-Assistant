using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {
        public enum StyleType {
            Passive,
            Melee,
            Mage,
            Ranged,
            Jad
        }

        public enum BossLocationType {
            N,
            S,
            W,
            E
        }

        public enum PlayerLocationType {
            N,
            S,
            W,
            E,
            NE,
            NW,
            SE,
            SW
        }

        public class Rotation {
            [JsonProperty("RotationIndex")]
            public int RotationIndex { get; set; }

            [JsonProperty("Phases")]
            public IList<Phase> Phases { get; set; }
        }
    }
}
