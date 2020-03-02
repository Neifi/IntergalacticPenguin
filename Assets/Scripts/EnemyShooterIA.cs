using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooterIA : UnityEngine.MonoBehaviour {

    public Rigidbody2D enemyRb;
    public GameObject bullet;
    private float nextFire;
    public float fireRate;

    public float speed = 4;
    public Transform target;
    public int distance;

    public float tiempoPreparacion;//tiempo antes de empezar las hordas
    public float enemyPorOleada;//numero de enemigos en una oleada
    public float tiempoSpawnEnemigo;//tiempo de spawn de cada enemigo

    public GameObject enemy;
    



    private void Start()
    {

        EnemyShot();
        
        

    }
    void FixedUpdate()
    {
        if ( transform.position.x >= distance)
        {
               transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
               target.position, speed * Time.deltaTime);//seguimiento del jugador en ambos ejes
               
        }
        else
        {
              transform.position = Vector2.MoveTowards(new Vector2(distance, transform.position.y),
              target.position, speed * Time.deltaTime);//seguimiento del jugador en eje y

        }

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
    
   

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }

    




   


}
