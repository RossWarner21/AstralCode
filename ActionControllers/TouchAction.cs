using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Linq;

namespace Astral {
    public class TouchAction : MonoBehaviour {

        List<Touch> currentTouches = new List<Touch>();
        List<Touch> previousTouches = new List<Touch>();
        Camera cam;
        RaycastHit2D hit;

        private void Start() {
            cam = Camera.main;
        }

        void Update() {
            if (Input.touchCount > 0) {
                UpdateTouchList(ref currentTouches);
                TriggerAllCurrentTouchHits();
                UpdateTouchList(ref previousTouches);
            }
        }
        
        void UpdateTouchList(ref List<Touch> touchList) {
            touchList = Input.touches.ToList();
        }

        void TriggerAllCurrentTouchHits() {
            foreach (Touch touch in currentTouches) {
                hit = WhatTheTouchHit(touch);

                if (TheTouchHitSomething()) {
                    TriggerTouchEvent(touch);
                }
            }
        }

        RaycastHit2D WhatTheTouchHit(Touch touch) {
            var origin = cam.ScreenPointToRay(touch.position).origin;
            return Physics2D.Raycast(origin, origin);
        }

        bool TheTouchHitSomething() {            
            return hit.collider;
        }

        void TriggerTouchEvent( Touch touch) {
            GameObject hitGO = hit.collider.gameObject;
            ActionController controller = hitGO.GetComponent<ActionController>();
            if (hitGO.GetComponent<ActionEvent>()) {
                hitGO.GetComponent<ActionEvent>().touchEvent.Invoke(controller, touch);
            }
        }
        
    }
}
