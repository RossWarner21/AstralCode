using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class PauseMenu : MonoBehaviour {

        public GameObject pauseMenu;

        public void PauseGame() {
            if (Time.timeScale > 0) {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
            }
            else {
                pauseMenu.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }
}