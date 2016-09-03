using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {
        private int _phaseIndex;
        public bool RotationFound => PossibleRotations.Count == 1;

        private bool IsLastPhase() {
            return RotationFound && PossibleRotations[0].Phases.Count - 1 <= _phaseIndex;
        }
        public List<Rotation> PossibleRotations { get; private set; }
        public List<Rotation> Rotations { get; }

        public Phase CurrentPhase { get; private set; }

        public bool PhaseDescisionInputRequired { get; private set; }
        public bool PhaseSameAttackStyle { get; private set; }

        public Zulrah() {
            Rotations = new List<Rotation>();
            foreach (string file in Directory.GetFiles("Rotations")) {
                string jsonString = new StreamReader(file).ReadToEnd();
                var singleRotation = JsonConvert.DeserializeObject<Rotation>(jsonString);

                Rotations.Add(singleRotation);
            }

            PossibleRotations = Rotations;

            CurrentPhase = Rotations[0].Phases.First();
        }

        /// <summary>
        /// Intializes/Resets the Zulrah Fight
        /// </summary>
        public void InitialPhase() {
            _phaseIndex = 0;
            PossibleRotations = Rotations;

            CurrentPhase = Rotations[0].Phases.First();
        }

        /// <summary>
        /// Used to figure out which zulrah rotation you are on. 
        /// </summary>
        /// <param name="currentStyle">What Phase you're being attacked by currently.</param>
        /// <returns></returns>
        public List<Phase> PossiblePhases(StyleType currentStyle) {
            PossibleRotations = PossibleRotations.Where(r => r.Phases[_phaseIndex].Style == currentStyle).ToList();

            //Get only distinct phases (otherwise you'd get two melee phases with same positioning for first round).
            var result = PossibleRotations.Select(p => p.Phases[_phaseIndex + 1])
                                          .GroupBy(p => new { p.BossLocation, p.Style })
                                          .Select(p => p.First()).ToList();

            _phaseIndex++;

            PhaseSameAttackStyle = result.Count != result.GroupBy(s => s.Style).Count();

            return result;
        }

        public List<Phase> PossiblePhases(BossLocationType bossLocation) {
            PossibleRotations = PossibleRotations.Where(r => r.Phases[_phaseIndex].BossLocation == bossLocation).ToList();

            //Get only distinct phases (otherwise you'd get two melee phases with same positioning for first round).
            var result = PossibleRotations.Select(p => p.Phases[_phaseIndex + 1])
                                          .GroupBy(p => new { p.BossLocation, p.Style })
                                          .Select(p => p.First()).ToList();

            _phaseIndex++;

            PhaseSameAttackStyle = result.Count != result.GroupBy(s => s.Style).Count();

            return result;
        }

        /// <summary>
        /// Used to select the next phase in zulrah's rotation. The Rotation must be found in order for this method to work, otherwise use PossiblePhase to find the correct tree.
        /// </summary>
        /// <returns>The next phase in Zulrah's rotation</returns>
        public Phase NextPhase() {
            //Reset to first phase if you hit the end of the rotation and are still killing zulrah.
            if(IsLastPhase()) {
                _phaseIndex = 0;
            }

            if (RotationFound) {
                CurrentPhase = PossibleRotations.Select(p => p.Phases[_phaseIndex + 1]).Single();
            } else {
                PhaseDescisionInputRequired = true;
                throw new InvalidOperationException();
            }

            _phaseIndex++;

            return CurrentPhase;
        }

        public Phase NextPhase(StyleType phaseChosen) {
            CurrentPhase = PossiblePhases(phaseChosen).Single();
            PhaseDescisionInputRequired = false;

            return CurrentPhase;
        }

        public Phase NextPhase(BossLocationType phaseChosen) {
            CurrentPhase = PossiblePhases(phaseChosen).Single();

            PhaseDescisionInputRequired = false;

            return CurrentPhase;
        }


    }
}
