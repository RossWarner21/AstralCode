using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Astral {
    public class ScoreController : MonoBehaviour {

        static public ScoreController self;

        [SerializeField]
        private Text scoreText;

        private float score;

        private void Awake() {
            if (self == null) self = this;
        }

        public void UpdateScore(float points) {
            score += points;
            scoreText.text = score.ToString();
        }
    }
}