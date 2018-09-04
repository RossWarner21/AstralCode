using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class WaveManager : MonoBehaviour {

        //A list of waves with an index to indicate the current wave
        //When a wave begins a timer starts to indicate elapsed time
        //When a wave ends it tells this class that it is time to move onto the next wave
        //When a wave ends it resets the wave timer, waits the alloated time and then begins the next wave
        //If the wave is a boss wave it wont go to the next wave until the boss is dead.

        public static WaveManager waveManager;

        [SerializeField]
        List<Wave> waves;

        int waveIndex;

        int formationIndex;
        public int CurrentFormation() {
            return formationIndex;
        }

        float waveDuration;
        public float WaveDuration() {
            return waveDuration;
        }

        bool readyForNextWave;

        public float timeBetweenWaves;

        private void Awake() {
            if(waveManager == null)
                waveManager = this;
        }

        private void Update() {

            BeginWave();

        }

        void BeginWave() {

            //waves[waveIndex].SortFormationsByStartTime();

        }
    }
}