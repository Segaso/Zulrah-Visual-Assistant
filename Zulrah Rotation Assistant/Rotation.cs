using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {
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

        public enum StyleType {
            Passive,
            Melee,
            Mage,
            Ranged,
            Jad
        }

        public class Rotation {
            [JsonProperty("RotationIndex")]
            public int RotationIndex { get; set; }

            [JsonProperty("Phases")]
            public IList<Phase> Phases { get; set; }

            public Phase CurrentPhase => Phases[Instance._phaseIndex];

            public Phase PreviousPhase
                => Instance._phaseIndex != 0 ? Phases[Instance._phaseIndex - 1] : Phases.Last();

            public Phase NextPhase
                => Phases.Count - 1 > Instance._phaseIndex ? Phases[Instance._phaseIndex + 1] : Phases.First();

            public bool PlayerLocationMoved => PreviousPhase.PlayerLocation != CurrentPhase.PlayerLocation;

            public bool BossLocationMoved => CurrentPhase.BossLocation != NextPhase.BossLocation;
        }
    }
}