using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eel : EnemyBehaviour
{
    int life;
    public int damage;
    public float movementvelocity;
    public float attackVelocity;
    public GameObject eel;
    public Rigidbody2D eelRb;
    public Transform attackSpawn;

    public override void ElectricShot(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage)
    {
        base.ElectricShot(attackSpawn, gameObjectRb, gameObject, damage);

        this.attackSpawn = attackSpawn;
        this.damage = damage;
        eelRb = gameObjectRb;
        eel = gameObject;
    }

    private void Start()
    {
        life = 1;
        damage = 1;

    }
}
