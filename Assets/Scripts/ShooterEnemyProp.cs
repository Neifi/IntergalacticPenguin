using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterEnemyProp : UnityEngine.MonoBehaviour
{
    public Rigidbody2D enemyRb;
    
    public GameObject bullet;

    public int speed;
    private float nextFire;
    public float fireRate;

    public Transform target;
    public Transform enemyBulletSpawn;

    public int distancia;

    public void Start()
    {
        
    }

    private void Update()
    {
        EnemyShot();
    }

    private void FixedUpdate()
    {
        
       // enemyRb.velocity = transform.right * speed;
    }

    public void EnemyShot()
    {
        if (Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Quaternion spawnRotation = Quaternion.identity;
            Instantiate(bullet, enemyRb.transform.position, spawnRotation);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
           // Debug.Log("Destroyed");
            Destroy(this.gameObject);
        }
    }

    private void OnDestroy()
    {

    }

}
