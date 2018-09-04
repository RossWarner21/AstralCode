using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Actions/Enemy/RapidShot")]
    public class ShotActionRapidShot : ShotAction {

        public override void Act(ActionController controller) {
            //StartShooting((EnemyActionController)controller);
        }

        public override void Act(ActionController controller, Touch touch) {
            throw new System.NotImplementedException();
        }

        //[SerializeField]
        //int projectilesPerVolley;

        //bool nextVolleyShot = true;
        //bool volleyCompleted = false;

        //public void StartShooting(EnemyActionController controller) {
        //    controller.StartCoroutine(ShootingEveryTimeBetweenShots(controller));
        //}

        //IEnumerator ShootingEveryTimeBetweenShots(EnemyActionController controller) {
        //    while (controller.Active()) {
        //        yield return new WaitForSecondsRealtime(controller.timeBetweenVolleys);
        //        ShootMultipleTimes(controller);
        //    }
        //}

        //void ShootMultipleTimes(EnemyActionController controller) {
        //    controller.StartCoroutine(BriefWaitBetweenEachShotOfAVolley(controller));
        //}

        //IEnumerator BriefWaitBetweenEachShotOfAVolley(EnemyActionController controller) {
        //    for (var i = 0; i < projectilesPerVolley; i++) {
        //        FireAllCannons(controller);
        //        yield return new WaitForSecondsRealtime(.15f);
        //    }
        //}

        //void FireAllCannons(EnemyActionController controller) {
        //    foreach(Cannon cannon in controller.cannons) {
        //        cannon.Shoot(controller);
        //    }
        //}        
    }
}