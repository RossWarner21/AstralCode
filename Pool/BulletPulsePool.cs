using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BulletPulsePool : BulletPool {

        public static BulletPulsePool self;

        private void Awake() {
            self = this;
        }
                
    }
}