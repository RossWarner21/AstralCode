using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Actions/Enemy/SingleShot")]
    public class ShotActionSingleShot : ShotAction {

        public override void Act(ActionController controller) {
            //StartShooting((EnemyActionController)controller);
        }

        public override void Act(ActionController controller, Touch touch) {
            throw new System.NotImplementedException();
        }

        //public void StartShooting(EnemyActionController controller) {
        //    controller.StartCoroutine(ShootingEveryTimeBetweenShots(controller));
        //}

        //IEnumerator ShootingEveryTimeBetweenShots(EnemyActionController controller) {
        //    while (controller.Active()) {
        //        yield return new WaitForSecondsRealtime(controller.timeBetweenVolleys);
        //        FireAllCannons(controller);
        //    }
        //}

        //void FireAllCannons(EnemyActionController controller) {
        //    foreach(Cannon cannon in controller.cannons) {
        //        cannon.Shoot(controller);
        //    }
        //}
    }
}