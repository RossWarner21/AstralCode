using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BulletHomingPool : BulletPool {

        public static BulletHomingPool self;

        private void Awake() {
            self = this;
        }
                
    }
}