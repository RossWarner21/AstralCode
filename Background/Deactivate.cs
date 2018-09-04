using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class Deactivate : MonoBehaviour {

        private void OnTriggerExit2D(Collider2D collision) {
            collision.gameObject.SetActive(false);
        }

    }
}