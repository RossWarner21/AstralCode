using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemySpawn : MonoBehaviour {

    [SerializeField]
    private GameObject enemyToSpawn;

	// Use this for initialization
	void Start () {
        Instantiate(enemyToSpawn);		
	}
}
