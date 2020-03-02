using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToSpawn : GameController {

    private GameObject[] powerUps;

    private GameObject[] asteroidsA;

    private GameObject[] enemy;
    private GameObject[] enemyShooter;

    private void Start()
    {
        
        powerUps = new GameObject[3];
        asteroidsA = new GameObject[3];
        enemy = new GameObject[2];
        enemyShooter = new GameObject[3];
       
    }
}
