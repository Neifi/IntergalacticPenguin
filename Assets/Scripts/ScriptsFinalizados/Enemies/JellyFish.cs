using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFish : EnemyBehaviour
{
    int life;
    public int damage;
    public float movementvelocity;
    public float attackVelocity;
    public GameObject jellyFish;
    public Rigidbody2D jellyFishRb;
    public Transform attackSpawn;

    public override void Stunt(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage)
    {
        base.Stunt(attackSpawn, gameObjectRb, gameObject, damage);

        base.Nibble(attackSpawn, gameObjectRb, gameObject, damage);

        this.attackSpawn = attackSpawn;
        this.damage = damage;
        jellyFishRb = gameObjectRb;
        jellyFish = gameObject;

    }
    

    private void Start()
    {
        life = 1;
        damage = 1;

    }
}
