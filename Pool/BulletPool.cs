using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BulletPool : Pool {

        public static BulletPool bulletPool;

        private void Awake() {
            bulletPool = this;
        }

        public GameObject BulletTypeSearch(WeaponTypes type) {
            switch (type) {
                case WeaponTypes.Ball:
                    return BulletBallPool.self.PoolSearch();
            }
            return null;
        }



    }
}