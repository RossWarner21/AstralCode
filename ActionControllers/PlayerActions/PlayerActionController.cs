using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class PlayerActionController : ActionController {

        public Action moveAction;

        private void Start() {
            UpdateTouchEvent();
        }

        void RunMoveAction() {
            moveAction.Act(this);
        }

        public void UpdateTouchEvent() {
            ActionEvent behaviorEvent = GetComponent<ActionEvent>();
            behaviorEvent.touchEvent.RemoveAllListeners();
            behaviorEvent.touchEvent.AddListener(moveAction.Act);
        }               
    }
}