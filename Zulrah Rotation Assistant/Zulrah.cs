using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;
using System.IO;
using System;

namespace Zulrah_Rotation_Assistant {
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
        SW,
    }

    public partial class Zulrah {
        private int PhaseIndex;
        public bool RotationFound { get; private set; }
        
        public List<List<Phase>> PossibleRotations { get; private set; }
        public List<List<Phase>> Rotations { get; private set; }

        public Zulrah() {
            var Serializer = new JsonSerializer();

            Rotations = new List<List<Phase>>();
            foreach (string File in Directory.GetFiles("Rotations")) {
                string JsonString = new StreamReader(File).ReadToEnd();
                var SingleRotation = JsonConvert.DeserializeObject<List<Phase>>(JsonString);

                Rotations.Add(SingleRotation);
            }

            PossibleRotations = Rotations;
        }

        public void NextPhase(StyleType CurrentStyle) {
            if(PossibleRotations.Count == 1) {
                RotationFound = true;
            } else {
                PossibleRotations = PossibleRotations.Where(R => R[PhaseIndex].Style == CurrentStyle).ToList();
            }
            PhaseIndex++;
        }
    }
}
