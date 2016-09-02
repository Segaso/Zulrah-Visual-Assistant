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

            private Phase _currentPhase;
            private IList<Phase> _possiblePhases;

            private ZulrahSingleton() {
                _rotations = new List<Rotation>();
                LoadRotations();
                
                //Initilize the _possiblePhases to the starting position of  zulrah (passive phase with 3 decision trees)
                _possiblePhases = _rotations.Select(p => p.Phases.First()).ToList();
            }

            public void Reset() {
                _possiblePhases = _rotations.Select(p => p.Phases.First()).ToList();
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

            /// <summary>
            /// 
            /// </summary>
            public void NextPhase(StyleType? attackType, BossLocationType? bossLocation) {
                if (_possiblePhases.Count == 1) {
                    OnPhaseChanged?.Invoke(_currentPhase, EventArgs.Empty);
                }
                else {
                    OnPhaseChanged?.Invoke(_possiblePhases, EventArgs.Empty);
                }
            }
        }
    }
}