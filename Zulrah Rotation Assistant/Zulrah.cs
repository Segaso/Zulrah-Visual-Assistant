namespace Zulrah_Rotation_Assistant {
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using System.Linq;
    using System.IO;
    using System;

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
        public bool RotationFound { get { return PossibleRotations.Count == 1; } }

        private bool isLastPhase() {
            return RotationFound && PossibleRotations[0].Count - 1 <= PhaseIndex;
        }
        public List<List<Phase>> PossibleRotations { get; private set; }
        public List<List<Phase>> Rotations { get; private set; }

        public Phase CurrentPhase { get; private set; }

    public Zulrah() {
            var Serializer = new JsonSerializer();

            Rotations = new List<List<Phase>>();
            foreach (string File in Directory.GetFiles("Rotations")) {
                string JsonString = new StreamReader(File).ReadToEnd();
                var SingleRotation = JsonConvert.DeserializeObject<List<Phase>>(JsonString);

                Rotations.Add(SingleRotation);
            }

            PossibleRotations = Rotations;

            CurrentPhase = Rotations[0].First();
        }

        /// <summary>
        /// Intializes/Resets the Zulrah Fight
        /// </summary>
        public void InitialPhase() {
            PhaseIndex = 0;
            PossibleRotations = Rotations;

            CurrentPhase = Rotations[0].First();
        }

        /// <summary>
        /// Used to figure out which zulrah rotation you are on. 
        /// </summary>
        /// <param name="CurrentStyle">What Phase you're being attacked by currently.</param>
        /// <returns></returns>
        public List<Phase> PossiblePhases(StyleType CurrentStyle) {
            PossibleRotations = PossibleRotations.Where(R => R[PhaseIndex].Style == CurrentStyle).ToList();

            //Get only distinct phases (otherwise you'd get two melee phases with same positioning for first round).
            var Result = PossibleRotations.Select(P => P[PhaseIndex + 1])
                                          .GroupBy(P => new { P.BossLocation, P.Style })
                                          .Select(P => P.First()).ToList<Phase>();

            PhaseIndex++;

            return Result;
        }

        /// <summary>
        /// Used to select the next phase in zulrah's rotation. The Rotation must be found in order for this method to work, otherwise use PossiblePhase to find the correct tree.
        /// </summary>
        /// <returns>The next phase in Zulrah's rotation</returns>
        public Phase NextPhase() {
            //Reset to first phase if you hit the end of the rotation and are still killing zulrah.
            if(isLastPhase()) {
                PhaseIndex = 0;
            }

            if (RotationFound) {
                CurrentPhase = PossibleRotations.Select(P => P[PhaseIndex + 1]).Single();
            } else {
                throw new InvalidOperationException();
            }

            PhaseIndex++;

            return CurrentPhase;
        }
    }
}
