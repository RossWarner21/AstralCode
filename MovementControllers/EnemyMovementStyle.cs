using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "MovementStyles")]
    public class EnemyMovementStyle : ScriptableObject {

        [SerializeField]
        private bool lookForward;
        [SerializeField]
        private BezierSpline spline;
        [SerializeField]
        private SplineWalkerMode splineMovementMode;
        [SerializeField]
        private bool goingForward = true;
        [SerializeField]
        private float duration;
        [SerializeField]
        private float waitDuration;

        public bool LookForward {
            get {
                return lookForward;
            }
        }        

        public SplineWalkerMode SplineMovementMode {
            get {
                return splineMovementMode;
            }
        }

        public BezierSpline Spline {
            get {
                return spline;
            }
        }

        public bool GoingForward {
            get {
                return goingForward;
            }
        }

        public float Duration {
            get { return duration; }
        }

        public float WaitDuration {
            get {
                return waitDuration;
            }            
        }       
    }
}