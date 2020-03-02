using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyBehaviour : MonoBehaviour
{
    new public string name = "enemy";
    float nextFire;

    public virtual void NormalShot(Transform attackSpawn, Rigidbody2D gameObjectRb, 
        GameObject gameObject, int damage,float fireRate) {


        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(gameObject, gameObjectRb.transform.position, spawnRotation);
        }


    }

    public virtual void LaserCuts(Transform attackSpawn, Rigidbody2D gameObjectRb,
       GameObject gameObject, int damage, float attackVelocity)
    { }
    public virtual void ElectricShot(Transform attackSpawn, Rigidbody2D gameObjectRb,
       GameObject gameObject, int damage)
    { }
    public virtual void NinjaStarShoot(Transform attackSpawn, Rigidbody2D gameObjectRb,
       GameObject gameObject, int damage, float attackVelocity)
    { }
    public virtual void Nibble(Transform attackSpawn, Rigidbody2D gameObjectRb,
        GameObject gameObject, int damage) {
        attackSpawn = gameObject.transform;
    }
    public virtual void FrontLunge(Transform attackSpawn, Rigidbody2D gameObjectRb,
       GameObject gameObject, int damage, float velocity)
    {
        attackSpawn = gameObject.transform;
    }
    public virtual void Stunt(Transform attackSpawn, Rigidbody2D gameObjectRb,
       GameObject gameObject, int damage)
    {
        attackSpawn = gameObject.transform;
    }
    public virtual void Sword(Transform attackSpawn, Rigidbody2D gameObjectRb,
      GameObject gameObject, int damage)
    {
        attackSpawn = gameObject.transform;
    }
}

    

