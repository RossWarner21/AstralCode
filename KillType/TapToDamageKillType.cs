using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "DamageTypes/TapToDamage")]
    public class TapToDamageKillType : EnemyDamageTouchAction {

        //Player taps on enemy
        //The tap does a portion of damage to it's total hit points
        //The tap does no more damage until a new touch has been initiated on this enemy

        public override void Act(ActionController controller, Touch touch) {
            switch (touch.phase) {
                case TouchPhase.Began:
                    DamageEnemy(controller);
                    break;
                case TouchPhase.Ended:
                    break;
            }
        }

        void DamageEnemy(ActionController controller) {
            Health health = controller.GetComponent<Health>();
            Debug.Log(health.gameObject.name);
            health.InflictDamage(damageDoneByPlayer);
        }
    }
}