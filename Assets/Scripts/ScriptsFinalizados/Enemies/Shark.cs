using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : EnemyBehaviour
{
    int life;
    public int damage;
    public float movementvelocity;
    public GameObject shark;
    public Rigidbody2D sharkRb;
    public Transform attackSpawn;

    public override void Nibble(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage)
    {
        base.Nibble(attackSpawn, gameObjectRb, gameObject, damage);
        this.attackSpawn = attackSpawn;
        this.damage = damage;
        sharkRb = gameObjectRb;
        shark = gameObject;
    }
   
    private void Start()
    {
        life = 1;
        damage = 1;

    }




}
