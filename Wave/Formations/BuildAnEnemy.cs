using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class BuildAnEnemy : MonoBehaviour {

        //The enemy config is passed through by the formation to set up the enemy template
        //It will change the cannons(sprite, position and type), shotAction, shotImage, health, killType


        EnemyConfiguration config;

        public void UpdateEnemysConfiguration(EnemyConfiguration enemyConfig) {
            config = enemyConfig;
            ChangeTemplateDetails();
        }

        void ChangeTemplateDetails() {
            UpdateActionController();
            UpdateCannons();
        }

        void UpdateActionController() {
            EnemyActionController controller = GetComponent<EnemyActionController>();
            controller.UpdateConfiguration(config);
        }

        void UpdateCannons() {
            if (ThereAreMoreCannonsThanChildren()) {
                AddChildren();
            }


        }
        
        void AddChildren() {
            

        }

        bool ThereAreMoreCannonsThanChildren() {
            return config.cannons.Count > transform.childCount;
        }
    }
}