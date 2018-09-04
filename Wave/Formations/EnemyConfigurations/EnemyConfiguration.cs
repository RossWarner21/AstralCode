using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "EnemyConfiguration")]
    public class EnemyConfiguration : ScriptableObject {

        public List<Cannon> cannons;
        public Vector3[] cannonPositions;
        public Sprite[] cannonSprites;

        public ShotAction howTheEnemyShoots;

        public float enemyHealth;

        public Sprite shotImage;

        public KillType[] enemyKillTypes;
    }
}