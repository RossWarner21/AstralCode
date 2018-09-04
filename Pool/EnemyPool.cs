using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class EnemyPool : Pool {

        public static EnemyPool self;

        private void Awake() {
            self = this;
        }
    }
}