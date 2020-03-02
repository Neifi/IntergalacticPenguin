using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerHead : EnemyBehaviour
{
    int life;
    public int damage;
    public float movementvelocity;
    public float attackVelocity;
    public GameObject hammerHead;
    public Rigidbody2D hammerHeadRb;
    public Transform attackSpawn;

    public override void FrontLunge(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage, float velocity)
    {
        base.FrontLunge(attackSpawn, gameObjectRb, gameObject, damage, velocity);

        this.attackSpawn = attackSpawn;
        this.damage = damage;
        hammerHeadRb = gameObjectRb;
        hammerHead = gameObject;
        attackVelocity = velocity;
    }

    private void Start()
    {
        life = 1;
        damage = 1;

    }
}
