using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "EnemyProfile")]
    public class EnemyProfile : ScriptableObject {
        [SerializeField]
        private EnemyDamageTouchAction howEnemyIsKilled;

        public EnemyDamageTouchAction EnemyDamageAction {
            get { return howEnemyIsKilled; }
        }

        [SerializeField]
        private Sprite baseShape;

        public Sprite BaseShape {
            get { return baseShape; }
        }

        [SerializeField]
        private ShotAction shotAction;

        public ShotAction ShotAction {
            get { return shotAction; }
        }

        [SerializeField]
        private List<Cannon> cannons;

        public List<Cannon> Cannons {
            get { return cannons; }
        }

        [SerializeField]
        private List<Vector3> cannonPositions;

        public List<Vector3> CannonPositions {
            get { return cannonPositions; }
        }

        [SerializeField]
        private float enemyHealth;

        public float EnemyHealth {
            get { return enemyHealth; }
        }

        [SerializeField]
        private float enemyScore;

        public float EnemyScore {
            get { return enemyScore; }
        }

        [SerializeField]
        private EnemyMovementStyle enemyMovementStyle;

        public EnemyMovementStyle EnemyMovementStyle {
            get { return enemyMovementStyle; }
        }
    }
}