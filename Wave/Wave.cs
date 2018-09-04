using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Astral {
    [CreateAssetMenu(menuName = "Wave")]
    public class Wave : ScriptableObject {

        [SerializeField]
        List<Spawn> objectsToBeSpawn;
        public List<Spawn> ObjectsToBeSpawn {
            get { return objectsToBeSpawn; }
        }

        [SerializeField]
        bool bossWave;

        public float WaveEndTime {
            get { return objectsToBeSpawn.Last().SpawnInitiateTime + objectsToBeSpawn.Last().MaximumDuration; }
        }
               
        public float FirstSpawnInitiateTime {
            get { return objectsToBeSpawn[0].SpawnInitiateTime; }
        }

        public bool BossWave {
            get { return bossWave; }
        }

        public void SortObjectsToBeSpawnedByInitiateTime() {
            objectsToBeSpawn.Sort(delegate (Spawn x, Spawn y) {
                return x.SpawnInitiateTime.CompareTo(y.SpawnInitiateTime);
            });
        }

        bool WaveFinished() {
            return WaveController.self.WaveSpawnIndex >= objectsToBeSpawn.Count - 1;
        }

    }
}