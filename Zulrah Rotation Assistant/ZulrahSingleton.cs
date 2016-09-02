using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {

        public class ZulrahSingleton {
            public delegate void ZulrahEventHandler(object sender, EventArgs eventArgs);

            private static ZulrahSingleton _instance;

            private readonly IList<Rotation> _rotations;
            private IList<Rotation> _possibleRotations;

            private int _phaseIndex;
            private bool RotationFound => _possibleRotations.Count == 1;
            private bool PhaseDecisionRequired => GetPossiblePhases().Count != 1;

            private ZulrahSingleton() {
                _rotations = new List<Rotation>();
                LoadRotations();

                //Initilize the _possiblePhases to the starting position of  zulrah (passive phase with 3 decision trees)
                Reset();
            }

            public void Reset() {
                _phaseIndex = 0;
                _possibleRotations = _rotations;
            }

            public static ZulrahSingleton Instance => _instance ?? (_instance = new ZulrahSingleton());


            public event ZulrahEventHandler OnPhaseChanged;
            public event ZulrahEventHandler OnPhaseDecisionRequired;

            /// <summary>
            ///     Loads the rotation data from the rotation.json files.
            /// </summary>
            private void LoadRotations() {
                foreach (var file in Directory.GetFiles("Rotations")) {
                    var rotation = JsonConvert.DeserializeObject<Rotation>(new StreamReader(file).ReadToEnd());
                    _rotations.Add(rotation);
                }
            }

            public void NextPhase() {
                if (!PhaseDecisionRequired) {
                    _phaseIndex++;
                    var phase = _possibleRotations.Select(S => S.Phases[_phaseIndex]).First();
                
                    OnPhaseChanged?.Invoke(phase, EventArgs.Empty);
                } else {
                    OnPhaseDecisionRequired?.Invoke(GetPossiblePhases(), EventArgs.Empty);
                }
            }

            public void NextPhaseByStyle(StyleType bossStyle) {
                if (PhaseDecisionRequired) {
                    _possibleRotations = _possibleRotations.Where(r => r.Phases[_phaseIndex + 1].Style == bossStyle).ToList();

                    var phases = GetPossiblePhases();

                    if (phases.Count == 1) {
                        _phaseIndex++;
                    }
                }
            }

            public void NextPhaseByLocation(BossLocationType bossLocation) {
                if (PhaseDecisionRequired) {
                    _possibleRotations = _possibleRotations.Where(r => r.Phases[_phaseIndex + 1].BossLocation == bossLocation).ToList();

                    var phases = GetPossiblePhases();

                    if (phases.Count == 1) {
                        _phaseIndex++;
                    }
                }
            }

            private IList<Phase> GetPossiblePhases() {
                return _possibleRotations.Select(p => p.Phases[_phaseIndex + 1])
                              .GroupBy(p => new { p.BossLocation, p.Style })
                              .Select(p => p.First()).ToList();
            }
        }
    }
}