using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {

    //The formation contains a collection of enemyConfigurations, positions, a start and end time, and the formation movement type
    //When called on by the wave it will set up the enemies in the correct positions relative to an area out of the way
    //To set up an enemy it will call a template from the pool, add it to the enemies list, and pass the enemy configuration to the BuildAnEnemy class
    //When it's start time is ready it will be called by the wave to begin
    //To launch it will move to the start position, activate all of the enemies and if the movement is as a group it will begin it's own movement.

    public enum FormationMovementType {
        MoveAsAGroup,
        MoveIndividually
    }

    [CreateAssetMenu(menuName = "Formation")]
    public class Formation : ScriptableObject {

        [SerializeField]
        Vector3 startPosition;

        [SerializeField]
        float startTime;
        public float StartTime() {
            return startTime;
        }

        [SerializeField]
        float endtTime;
        public float EndtTime() {
            return endtTime;
        }

        [SerializeField]
        EnemyConfiguration[] enemyConfigs;

        [SerializeField]
        Vector3[] enemyPositions;

        [SerializeField]
        FormationMovementType formationMovementType;

        [SerializeField]
        EnemyMovementStyle[] enemyMovementStyles;

        List<GameObject> enemies;
                
        public void SetupFormation() {

        }

        public void BeginFormation() {

        }

        

    }
}