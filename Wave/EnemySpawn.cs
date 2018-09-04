using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    [CreateAssetMenu(menuName = "Spawns/EnemySpawn")]
    public class EnemySpawn : SpawnObjects {

        public override void SpawnObject() {SpawnEnemyWithStats(); PositionEnemy(); createdObject.SetActive(true); }
        public override void SpawnObject(bool overrideActiveState) {SpawnEnemyWithStats(); PositionEnemy(); createdObject.SetActive(overrideActiveState); }

        //Specific Enemy needs to be spawned
        //Details of enemy saved on scriptable object of this
        //Instantiate base prefab
        //Customise prefab to match requirements of enemyProfile
        //Insert into scene

        [SerializeField]
        private EnemyProfile enemyProfile;

        void SpawnEnemyWithStats() {
            GameObject newEnemy = EnemyPool.self.PoolSearch(safeZone);
            //Instantiate(objectToBeSpawned, safeZone, new Quaternion());
            createdObject = newEnemy;
            SetUpEnemyStats();            
        }

        void SetUpEnemyStats() {
            SetUpActionController();
            SetUpSprite();
            SetUpEnemyDeathMechanics();
            SetUpEnemyMovementStyle();
            SetUpEnemyScore();
        }

        void SetUpActionController() {
            EnemyActionController enemyActionController = createdObject.GetComponent<EnemyActionController>();
            //enemyActionController.NewAction(enemyProfile.ShotAction);
            enemyActionController.NewCannons(enemyProfile.Cannons);
        }

        void SetUpSprite() {
            SpriteRenderer spriteRenderer = createdObject.GetComponent<SpriteRenderer>();
            spriteRenderer.sprite = enemyProfile.BaseShape;
            spriteRenderer.color = enemyProfile.EnemyDamageAction.EnemyColor;
        }

        void SetUpEnemyDeathMechanics() {
            HealthEnemy enemyHealth = createdObject.GetComponent<HealthEnemy>();
            enemyHealth.UpdateKillType(enemyProfile.EnemyDamageAction);
            enemyHealth.UpdateEnemyHealth(enemyProfile.EnemyHealth);
        }

        void SetUpEnemyMovementStyle() {
            SplineWalker splineWalker = createdObject.GetComponent<SplineWalker>();
            splineWalker.UpdateSplineWalkerDetails(enemyProfile.EnemyMovementStyle);
        }

        void SetUpEnemyScore() {
            EnemyScore enemyScore = createdObject.GetComponent<EnemyScore>();
            enemyScore.UpdateEnemyScore(enemyProfile.EnemyScore);
        }

        void PositionEnemy() {
            createdObject.transform.position = spawnPosition;            
        }

    }
}