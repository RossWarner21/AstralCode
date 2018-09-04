using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BulletMinePool : BulletPool {

        public static BulletMinePool self;

        private void Awake() {
            self = this;
        }
                
    }
}