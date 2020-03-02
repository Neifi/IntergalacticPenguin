using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampFish20 : EnemyBehaviour
{
    int life;
    public int damage;
    public float movementvelocity;
    public float attackVelocity;
    public GameObject lampdFish20;
    public Rigidbody2D lampdFish20Rb;
    public Transform attackSpawn;

    public override void Nibble(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage)
    {
        base.Nibble(attackSpawn, gameObjectRb, gameObject, damage);

        this.attackSpawn = attackSpawn;
        this.damage = damage;
        lampdFish20Rb = gameObjectRb;
        lampdFish20 = gameObject;
        
    }
    

    public override void ElectricShot(Transform attackSpawn, Rigidbody2D gameObjectRb, GameObject gameObject, int damage)
    {
        base.ElectricShot(attackSpawn, gameObjectRb, gameObject, damage);

        this.attackSpawn = attackSpawn;
        this.damage = damage;
        lampdFish20Rb = gameObjectRb;
        lampdFish20 = gameObject;
    }

    private void Start()
    {
        life = 1;
        damage = 1;

    }
}
