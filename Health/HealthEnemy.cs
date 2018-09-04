using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class HealthEnemy : Health {

        public override void DeathMechanics() {
            Death();
        }

        [SerializeField]
        private EnemyDamageTouchAction howTheEnemyIsDamaged;
        
        private void OnEnable() {
            UpdateTouchEvent();
        }

        public void UpdateEnemyHealth(float newTotalHealth) {
            totalHealth = newTotalHealth;
        }

        public void UpdateKillType(EnemyDamageTouchAction damageType) {
            howTheEnemyIsDamaged = damageType;
            UpdateTouchEvent();
        }

        void UpdateTouchEvent() {
            ActionEvent damageEvent = GetComponent<ActionEvent>();
            damageEvent.touchEvent.RemoveAllListeners();
            damageEvent.touchEvent.AddListener(howTheEnemyIsDamaged.Act);
        }

        void Death() {
            GetComponent<EnemyScore>().AddPointsToScore();
            gameObject.SetActive(false);
        }



    }
}