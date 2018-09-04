using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Astral {
    [System.Serializable]
    public class GameOverEvent : UnityEvent {
    }

    public class GameManager : MonoBehaviour {

        private bool gameActive;
        public static GameManager self;
        public GameOverEvent gameOverEvent;
        public SearchQueries search;

        private void Awake() {            
            self = this;
            gameActive = true;
            search = new SearchQueries();
        }

        public bool IsTheGameActive() {
            return gameActive;
        }

        public void GameOver() {
            gameActive = false;
            gameOverEvent.Invoke();
            Time.timeScale = 0;
            StopAllCoroutines();
        }

        public void Restart() {
            SceneManager.LoadScene(Application.loadedLevel);
            Time.timeScale = 1;
        }

    }
}