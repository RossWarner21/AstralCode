using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {

    public class HealthPlayer : Health {

        public override void DeathMechanics() {
            if(lives == 0) {
                GameOver();
            }
            else {
                BeginNextLife();
            }
        }

        void GameOver() {
            GameManager.self.GameOver();
            gameObject.SetActive(false);
        }

        void BeginNextLife() {
            RestoreHealth();
            lives--;
        }

        public static HealthPlayer self;

        Collider2D collider;

        [SerializeField]
        private int lives;

        [SerializeField]
        private float maximumHealth;

        private void Awake() {
            if (self == null) self = this;
            lives = 3;
        }

        private void OnTriggerStay2D(Collider2D collision) {
            collider = collision;

            if (ItIsACollisionThreat()){
                DetermineAndEnactDamageToPlayer();
            }
            //collision.gameObject.SetActive(false);
        }
        
        bool ItIsACollisionThreat() {
            return collider.GetComponent<PlayerCollisionThreat>();
        }

        void DetermineAndEnactDamageToPlayer() {

            PlayerCollisionThreats collisionThreat = RetrieveCollisionThreat();

            switch (collisionThreat) {
                //case PlayerCollisionThreats.bullet:                    
                //    BulletDamage();                    
                //    break;
                case PlayerCollisionThreats.enemy:
                    InstantDeath();
                    break;
                case PlayerCollisionThreats.environment:
                    InstantDeath();
                    break;
            }
        }

        PlayerCollisionThreats RetrieveCollisionThreat() {
            return collider.GetComponent<PlayerCollisionThreat>().CollisionThreat();
        }

        public void InstantDeath() {
            totalHealth = 0;
            DeathMechanics();
        }        

        void RestoreHealth() {
            totalHealth = maximumHealth;
        }
    }
}