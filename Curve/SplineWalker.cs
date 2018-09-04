using UnityEngine;
using System.Collections; 

namespace Astral
{
    public class SplineWalker : MonoBehaviour
    {
        [SerializeField]
        private EnemyMovementStyle movementStyle;

        private bool goingForward = true;
        private bool waiting = false;

        private float progress;
        private Vector3 difference;

        private int nextPointIndex;

        public void UpdateSplineWalkerDetails(EnemyMovementStyle enemyMovementStyle) {
            movementStyle = enemyMovementStyle;
        }

        private void OnEnable()
        {
            difference = movementStyle.Spline.GetControlPoint(0) - transform.position;

            nextPointIndex = 1;
        }

        //Walker starts
        //Walker detects which point it is approaching
        //When walker is in range of point checks if it is a wait point
        //If it is a wait point it will then wait for a set amount of time
        //Once the time has elapsed it will begin to look at the next point

        private void FixedUpdate()
        {
            if (!waiting) {
                WalkerIsActive();
            }
        }

        void WalkerIsActive() {
            if (goingForward) {
                MoveWalkerProgressionForward();
            }
            else if (!goingForward) {
                MoveWalkerProgressionBackwards();
            }

            MoveWalkerTransformWithProgression();

            if (TheWalkerIsAtTheNextPoint()) {
                if (movementStyle.Spline.GetWaitAtPoint(nextPointIndex)) {
                    //Debug.Log(nextPointIndex);
                    //Debug.Log(difference);
                    //Debug.Log(transform.position);
                    //Debug.Log(spline.GetControlPoint(nextPointIndex));
                    //Debug.Log(DistanceBetweenWalkerAndUpComingPoint() + " " + HalfOfWalkersWidth());
                    StartCoroutine(WaitTimer());
                }
                IncrementNextPointIndex();
            }
        }

        void MoveWalkerProgressionForward() {
            progress += Time.fixedDeltaTime / movementStyle.Duration;
            if (progress > 1f) {
                if (movementStyle.SplineMovementMode == SplineWalkerMode.Once) {
                    progress = 1f;
                    nextPointIndex = 1;
                }
                else if (movementStyle.SplineMovementMode == SplineWalkerMode.Loop) {
                    progress -= 1f;
                    nextPointIndex = 1;
                }
                else {
                    progress = 2f - progress;
                    goingForward = false;
                    //nextPointIndex = spline.ControlPointCount - 1;
                    //Debug.Log(nextPointIndex + " " + spline.ControlPointCount);
                }
            }
        }

        void MoveWalkerProgressionBackwards() {
            progress -= Time.deltaTime / movementStyle.Duration;
            if (progress < 0f) {
                progress = -progress;
                goingForward = true;
                nextPointIndex = 1;
            }
        }

        void MoveWalkerTransformWithProgression() {
            Vector3 position = movementStyle.Spline.GetPoint(progress) - difference;
            transform.position = position;
            if (movementStyle.LookForward) {
                transform.LookAt(position + movementStyle.Spline.GetDirection(progress));
            }
        }

        bool TheWalkerIsAtTheNextPoint() {
            return DistanceBetweenWalkerAndUpComingPoint() < 0.08;
                //< HalfOfWalkersWidth();
        }

        float DistanceBetweenWalkerAndUpComingPoint() {
            return Mathf.Abs(Vector3.Distance(transform.position, movementStyle.Spline.GetControlPoint(nextPointIndex) - difference));
        }
        
        float HalfOfWalkersWidth() {
            return GetComponent<SpriteRenderer>().bounds.extents.x;
        }

        IEnumerator WaitTimer( ) {
            waiting = true;
            //Debug.Log(nextPointIndex);
            yield return new WaitForSecondsRealtime(movementStyle.WaitDuration);
            //Debug.Log(nextPointIndex);
            waiting = false;
        }

        void IncrementNextPointIndex() {
            if (goingForward && nextPointIndex < movementStyle.Spline.ControlPointCount - 1)
                nextPointIndex++;
            else if(!goingForward && nextPointIndex > 0)
                nextPointIndex--;

            //Debug.Log(nextPointIndex + " " + spline.ControlPointCount);
        }

    }
}