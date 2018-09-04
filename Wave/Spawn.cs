using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public abstract class Spawn : ScriptableObject {

        protected Vector3 safeZone = new Vector3(100, 100, 100);

        [SerializeField]
        private float spawnInitiateTime;
        public float SpawnInitiateTime {
            get { return spawnInitiateTime; }
        }

        [SerializeField]
        private float maximumDuration;
        public float MaximumDuration {
            get { return maximumDuration; }
        }


        public abstract void SpawnObject();

    }
}