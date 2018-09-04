using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Actions/Player/Move")]
    public class ActionPlayerMove : Action {

        public override void Act(ActionController controller) {
            return;
        }

        public override void Act(ActionController controller, Touch touch) {
            switch (touch.phase) {
                case TouchPhase.Moved:
                    controller.transform.position = Camera.main.ScreenPointToRay(touch.position).origin;
                    break;
            }
        }
    }
}