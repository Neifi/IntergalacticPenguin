using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarineLeopard : EnemyBehaviour
{
    int life;
    public int distance;
    public int damage;
    public float movementvelocity;
    public float fireRate;
    public GameObject marineLeopard;
    public Rigidbody2D marineLeopardRb;
    public Transform attackSpawn;
    public Transform target;
   
    

    private void Start()
    {
        life = 1;
        damage = 1;
        fireRate = 0.5f;
        NormalShot(attackSpawn,marineLeopardRb,marineLeopard,damage,fireRate);
    }

    private void Movement()
    {
        if (transform.position.x >= distance)
        {
            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
            target.position, movementvelocity * Time.deltaTime);//seguimiento del jugador en ambos ejes

        }
        else
        {
            transform.position = Vector2.MoveTowards(new Vector2(distance, transform.position.y),
            target.position, movementvelocity * Time.deltaTime);//seguimiento del jugador en eje y

        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}

