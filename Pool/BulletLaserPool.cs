using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BulletLaserPool : BulletPool {

        public static BulletLaserPool self;

        private void Awake() {
            self = this;
        }
                
    }
}