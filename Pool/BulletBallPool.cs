using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BulletBallPool : BulletPool {

        public static BulletBallPool self;

        private void Awake() {
            self = this;
        }
                
    }
}