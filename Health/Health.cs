using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public abstract class Health : MonoBehaviour {

        public abstract void DeathMechanics();

        [SerializeField]
        protected float totalHealth;
        public float TotalHealth {
            get { return totalHealth; }
        }

        public void InflictDamage(float damage) {
            DeductHitPoints(damage);
            if (RunOutOfHitPoints()) DeathMechanics();
        }

        public void DeductHitPoints(float damage) {
            totalHealth -= damage;            
        }
        
        protected bool RunOutOfHitPoints() {
            return totalHealth <= 0;
        }

    }
}