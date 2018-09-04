using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Spawns/FormationSpawn")]
    public class FormationSpawn : Spawn {

        //WaveController Calls on formation to spawn
        //Loop through and create individual objects that make up formation
        //Position them correctly relative to the safeZone
        //Move to starting position

        public override void SpawnObject() { SpawnFormation(); }


        [SerializeField]
        private List<SpawnObjects> formationObjects;
        
        void SpawnFormation() {
            List<GameObject> spawnedObjects = SpawnAndListObjectsAtSafeZone();
            ActivateAllObjects(spawnedObjects);
        }

        List<GameObject> SpawnAndListObjectsAtSafeZone() {
            List<GameObject> tempList = new List<GameObject>();

            for(var i = 0; i < formationObjects.Count; i++) {
                formationObjects[i].SpawnObject(true);
                tempList.Add(formationObjects[i].CreatedObject);
            }
            return tempList;
        }

        void ActivateAllObjects(List<GameObject> spawnedObjects) {
            for (var i = 0; i < spawnedObjects.Count; i++) {
                spawnedObjects[i].SetActive(true);
            }
        }

    }
}