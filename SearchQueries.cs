using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class SearchQueries {

        public bool IsThePlayerActiveInTheScene {
            get { return GameObject.FindGameObjectWithTag("Player").activeSelf; }
        }

        public GameObject PlayerGameObject {
            get { return GameObject.FindGameObjectWithTag("Player"); }
        }

        public bool DidICollideWithThePlayer(Collider2D comparisonCollider) {
            return PlayerGameObject.GetComponent<Collider2D>() == comparisonCollider;
        }

        public bool IsThisThePlayer (GameObject goToCompare) {
            return goToCompare == PlayerGameObject;
        }

    }
}