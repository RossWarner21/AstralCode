using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class WaveController : MonoBehaviour {

        public static WaveController self;

        [SerializeField]
        private int waveIndex = 0;

        [SerializeField]
        private int waveSpawnIndex = 0;
        public int WaveSpawnIndex {
            get { return waveSpawnIndex; }
        }

        [SerializeField]
        private List<Wave> wavesToSpawn;

        [SerializeField]
        private float timeElapsed;

        [SerializeField]
        public float waitDurationBetweenWaves;

        private bool waiting = false;

        public Wave CurrentWave {
            get { return wavesToSpawn[waveIndex]; }
        }

        public Spawn NextObjectToBeSpawned {
            get { return CurrentWave.ObjectsToBeSpawn[waveSpawnIndex]; }
        }

        public Spawn LastObjectSpawned {
            get { return CurrentWave.ObjectsToBeSpawn[waveSpawnIndex - 1]; }
        }

        bool ThereAreMoreObjectsInTheCurrentWave {
            get { return waveSpawnIndex < CurrentWave.ObjectsToBeSpawn.Count; }
        }

        bool ThereAreMoreWavesToInitiate {
            get { return waveIndex < wavesToSpawn.Count -1; }
        }

        bool ReadyForTheNextSpawnObject {
            get { return timeElapsed >= NextObjectToBeSpawned.SpawnInitiateTime; }
        }

        private void Awake() {
            if(self == null) { self = this; }

            CallWavesToSortObjectsToBeSpawnedByInitiateTime();
            SortWavesToBeSpawnedByInitiateTime();
        }

        private void Update() {
            timeElapsed += Time.deltaTime;

            if (!waiting) {
                RunCurrentWave();
            }            
        }

        void RunCurrentWave() {
            if (TheWaveHasEnded()) {                                
                StartCoroutine(WaitAndBeginTheNextWaveBegins());
            }
            else if (ThereAreMoreObjectsInTheCurrentWave) {
                SpawnNextWave();
            }
        }

        bool TheWaveHasEnded() {
            if (!ThereAreMoreObjectsInTheCurrentWave) {                
                if (timeElapsed > CurrentWave.WaveEndTime)
                    return true;
            }
            return false;
        }

        void SpawnNextWave() {
            if (ReadyForTheNextSpawnObject) {
                NextObjectToBeSpawned.SpawnObject();
                waveSpawnIndex++;
            }
        }

        void CallWavesToSortObjectsToBeSpawnedByInitiateTime() {
            foreach (Wave wave in wavesToSpawn) {
                wave.SortObjectsToBeSpawnedByInitiateTime();
            }
        }

        void SortWavesToBeSpawnedByInitiateTime() {
            wavesToSpawn.Sort(delegate (Wave x, Wave y) {
                return x.FirstSpawnInitiateTime.CompareTo(y.FirstSpawnInitiateTime);
            });
        }

        IEnumerator WaitAndBeginTheNextWaveBegins() {
            waiting = true;
            yield return new WaitForSecondsRealtime(waitDurationBetweenWaves);
            if (ThereAreMoreWavesToInitiate) {
                BeginNextWave();                
            }
        }

        void BeginNextWave() {
            waveSpawnIndex = 0;
            waveIndex++;
            timeElapsed = 0;
            waiting = false;
        }
    }
}