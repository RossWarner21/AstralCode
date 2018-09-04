using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {

    public enum PlayerCollisionThreats {
        bullet,
        enemy,
        environment
    }

    public class PlayerCollisionThreat : MonoBehaviour {
        [SerializeField]
        private PlayerCollisionThreats collisionThreat;

        public PlayerCollisionThreats CollisionThreat() {
            return collisionThreat;
        }

    }
}