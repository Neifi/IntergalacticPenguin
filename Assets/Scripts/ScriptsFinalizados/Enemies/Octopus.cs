using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Octopus : EnemyBehaviour
{
    int life;
    public int damage;
    public float movementvelocity;
    public float attackVelocity;
    public GameObject octopus;
    public Rigidbody2D octopusRb;
    public Transform attackSpawn;

    public override void NinjaStarShoot(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage, float attackVelocity)
    {
        base.NinjaStarShoot(attackSpawn, gameObjectRb, gameObject, damage, attackVelocity);

        this.attackSpawn = attackSpawn;
        this.damage = damage;
        octopusRb = gameObjectRb;
        octopus = gameObject;

    }
    

    private void Start()
    {
        life = 1;
        damage = 1;

    }
}
