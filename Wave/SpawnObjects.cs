using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public abstract class SpawnObjects : Spawn {

        public abstract void SpawnObject(bool overrideActiveState);

        [SerializeField]
        protected GameObject objectToBeSpawned;

        protected GameObject createdObject;
        public GameObject CreatedObject {
            get { return createdObject; }
        }

        [SerializeField]
        protected Vector3 spawnPosition;

    }
}