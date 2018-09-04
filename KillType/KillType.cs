using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Astral {
    public class KillType : MonoBehaviour {

        public bool action; //Defined by spawn point
        public float fireRate;
        public float health; //Defined by spawn point
        public Vector2 speed; //Defined by spawn point

        public float minTouchDistance; //Stays same
        public float touchPos; //Realtime calculation of touch position
        public float touchDamage; //Stays same     
        public Color color; //Unique to each variation
                

    }
}