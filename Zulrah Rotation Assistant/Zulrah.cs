using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Zulrah_Rotation_Assistant {
    public partial class Zulrah {
        public delegate void ZulrahNextEventHandler(Rotation sender);

        public delegate void ZulrahPhaseDecisionEventHandler(IList<Phase> phases, bool sameAttackStyle);

        private static Zulrah _instance;

        private readonly IList<Rotation> _rotations;

        private int _phaseIndex;
        private IList<Rotation> _possibleRotations;

        private Zulrah() {
            _rotations = new List<Rotation>();
            LoadRotations();

            //Initilize the _possiblePhases to the starting position of  zulrah (passive phase with 3 decision trees)
            Reset();
        }

        private bool PhaseDecisionRequired => GetPossiblePhases().Count != 1;

        private bool PhaseSameAttackStyle
            => GetPossiblePhases().GroupBy(s => s.Style).Count() != GetPossiblePhases().Count;


        public static Zulrah Instance => _instance ?? (_instance = new Zulrah());

        public void Start() => Reset();

        public void Reset() {
            _phaseIndex = 0;
            _possibleRotations = _rotations;

            OnPhaseChanged?.Invoke(_possibleRotations.First());
            OnPhaseDecisionRequired?.Invoke(GetPossiblePhases(), PhaseSameAttackStyle);
        }


        public event ZulrahNextEventHandler OnPhaseChanged;
        public event ZulrahPhaseDecisionEventHandler OnPhaseDecisionRequired;

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
                IncreasePhaseIndex();

                var phase = _possibleRotations.First();
                OnPhaseChanged?.Invoke(phase);
            }
            else {
                OnPhaseDecisionRequired?.Invoke(GetPossiblePhases(), PhaseSameAttackStyle);
            }
        }

        public void NextPhaseByStyle(StyleType bossStyle) {
            if (PhaseDecisionRequired) {
                var tempRotations = _possibleRotations.Where(r => r.NextPhase.Style == bossStyle).ToList();

                if (tempRotations.Count != 0) {
                    _possibleRotations = tempRotations;
                }
                var phases = GetPossiblePhases();

                if (phases.Count == 1) {
                    IncreasePhaseIndex();
                    OnPhaseChanged?.Invoke(_possibleRotations.First());
                }
                else {
                    OnPhaseDecisionRequired?.Invoke(phases, PhaseSameAttackStyle);
                }
            }
        }

        public void NextPhaseByLocation(BossLocationType bossLocation) {
            if (PhaseDecisionRequired) {
                var tempRotations = _possibleRotations.Where(r => r.NextPhase.BossLocation == bossLocation).ToList();

                if (tempRotations.Count != 0) {
                    _possibleRotations = tempRotations;
                }

                var phases = GetPossiblePhases();

                if (phases.Count == 1) {
                    IncreasePhaseIndex();
                    OnPhaseChanged?.Invoke(_possibleRotations.First());
                }
                else {
                    OnPhaseDecisionRequired?.Invoke(phases, PhaseSameAttackStyle);
                }
            }
        }

        private IList<Phase> GetPossiblePhases() {
            return _possibleRotations.Select(p => p.NextPhase)
                .GroupBy(p => new {p.BossLocation, p.Style})
                .Select(p => p.First()).ToList();
        }

        private void IncreasePhaseIndex() {
            _phaseIndex++;

            if (_phaseIndex + 1 > _possibleRotations.Min(r => r.Phases.Count)) _phaseIndex = 0;
        }
    }
}