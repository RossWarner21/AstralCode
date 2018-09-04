using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Cannons/LaserCannon")]
    public class LaserCannon : Cannon {

        public override void Shoot(CannonObject controller) {
            ShotBehavior(controller);
        }

        void ShotBehavior(CannonObject controller) {



        }

    }
}