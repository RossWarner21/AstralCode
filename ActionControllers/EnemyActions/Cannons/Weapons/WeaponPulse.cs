﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class WeaponPulse : Weapon {

        public override void WeaponHit() {
            throw new System.NotImplementedException();
        }

        CircleCollider2D circleCollider2D;
        public CircleCollider2D CircleCollider2D {
            get { return circleCollider2D; }
        }

        private void Awake() {
            circleCollider2D = GetComponent<CircleCollider2D>();
        }

        private void FixedUpdate() {
            weaponBehaviour.WeaponAction(this);
        }

        public override void AdjustSize() {
            throw new System.NotImplementedException();
        }
    }
}