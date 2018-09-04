using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public abstract class Pool : MonoBehaviour {

        public int size;
        public GameObject prefab;
        public List<GameObject> pooled = new List<GameObject>();

        //public abstract bool Find();
        //public abstract Pool GetPool();
        //public abstract bool FireType();

        public GameObject PoolSearch() {
            foreach (GameObject go in pooled) {
                if (!go.activeInHierarchy) {
                    return go;
                }
            }

            if (pooled.Count < size) {
                var go = Instantiate(prefab);
                go.transform.parent = transform;
                pooled.Add(go);
                go.SetActive(false);
                return go;
            }

            return null;
        }

        public GameObject PoolSearch(Vector3 position) {
            foreach (GameObject go in pooled) {
                if (!go.activeInHierarchy) {
                    return go;
                }
            }

            if (pooled.Count < size) {
                var go = Instantiate(prefab);
                go.transform.parent = transform;
                transform.position = position;
                pooled.Add(go);
                go.SetActive(false);
                return go;
            }

            return null;
        }

    }
}