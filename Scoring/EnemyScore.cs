using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Astral {
    public class EnemyScore : MonoBehaviour {

        [SerializeField]
        private float enemyPoints;

        public void UpdateEnemyScore(float newScore) {
            enemyPoints = newScore;
        }

        public void AddPointsToScore() {
            ScoreController.self.UpdateScore(enemyPoints);
        }
    }
}