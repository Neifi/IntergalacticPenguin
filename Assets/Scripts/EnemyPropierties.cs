using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyPropierties : UnityEngine.MonoBehaviour
{

    public Rigidbody2D enemyRb;
    public GameObject bullet;
    private float nextFire;
    public float fireRate;

    
    public int speed;

    private void FixedUpdate()
    {
        enemyRb.velocity = transform.right * -speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == ("Player")){
            Debug.Log("Destroyed");
            Destroy(gameObject);
        }
    }

   

    private void OnDestroy()
    {

    }

}


