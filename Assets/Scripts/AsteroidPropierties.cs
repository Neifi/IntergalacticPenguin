using UnityEngine;

public class AsteroidPropierties : UnityEngine.MonoBehaviour
{


    public Transform powerTransform;
    public Rigidbody2D asteroidRb;
    public int speed;
    public int asteroidLife;
    private bool destroyed;
 
    // Use this for initialization



    private void Start()
    {
        asteroidLife = 3;
        destroyed = false;
      
    }

    // Update is called once per frame
    private void Update()
    {

        if (asteroidLife <= 0)
        {
            Quaternion spawnRotation = Quaternion.identity;
            destroyed = true;
            if (destroyed)
            {

               // Instantiate(gc.powerUps[0], powerTransform.transform.position, spawnRotation);
            }
            Destroy(gameObject);
            //animacion to wapa
        }
    }
    private void FixedUpdate()
    {
        asteroidRb.velocity = transform.right * -speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Bullet"))
        {
            Destroy(collision.gameObject);
            asteroidLife--;
        }
         if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }

    }



}
