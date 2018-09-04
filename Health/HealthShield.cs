using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class HealthShield : Health {

        public void HealthShieldSetUp(float health, WeaponShield shield) {
            totalHealth = health;
            parentShield = shield;
        }

        private WeaponShield parentShield;

        public override void DeathMechanics() {
            parentShield.ShieldHasBeenDestroyed();
        }



    }
}