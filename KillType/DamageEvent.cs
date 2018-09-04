using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Astral {
    [System.Serializable]
    public class TouchDamageEvent : UnityEvent<Touch> {
    }

    public class DamageEvent : MonoBehaviour {
        public TouchDamageEvent touchEvent;
    }
}