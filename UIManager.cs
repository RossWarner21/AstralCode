using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class UIManager : MonoBehaviour {

        [SerializeField]
        private GameObject gameOverObject;

        private void Start() {

            GameManager.self.gameOverEvent.AddListener(GameOverRoutine);

        }

        void GameOverRoutine() {
            gameOverObject.SetActive(true);
        }
    }
}