using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Actions/Enemy/BurstShot")]
    public class ShotActionBurstShot : ShotAction {

        public override void Act(ActionController controller) {
            //StartShooting((EnemyActionController)controller);
        }

        public override void Act(ActionController controller, Touch touch) {
            throw new System.NotImplementedException();
        }

        //[SerializeField]
        //int shotsPerBurst;
        //[SerializeField]
        //float angleDifferenceBetween;


        //public void StartShooting(EnemyActionController controller) {
        //    controller.StartCoroutine(ShootingEveryTimeBetweenShots(controller));
        //}

        //IEnumerator ShootingEveryTimeBetweenShots(EnemyActionController controller) {
        //    while (controller.Active()) {
        //        yield return new WaitForSecondsRealtime(controller.timeBetweenVolleys);
        //        for (var i = 0; i < shotsPerBurst; i++) {
        //            FireAllCannons(controller);
        //        }
        //    }
        //}

        //void FireAllCannons(EnemyActionController controller) {
        //    foreach(Cannon cannon in controller.cannons) {
        //        cannon.Shoot(controller);
        //    }
        //}
    }
}