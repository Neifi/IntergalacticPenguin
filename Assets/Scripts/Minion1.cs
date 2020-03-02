using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{


    public Rigidbody2D enemyRb;
    public GameObject bullet;
    private float nextFire;
    public float fireRate;

    public float BulletSpeed = 10;
    
    public Rigidbody2D bulletRB;
    
    public PlayerManager playerManager;

    void Start()
    {
        bulletRB = GetComponent<Rigidbody2D>();
        bulletRB.gravityScale = 0.0f;
        bulletRB.mass = 0.1f;
        bulletRB.velocity = transform.right * BulletSpeed;
        playerManager = new PlayerManager();
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == ("Player"))
        {
            playerManager.PlayerLife--;
            Destroy(gameObject);
        }
    }
    
   
}

