using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Bullets : UnityEngine.MonoBehaviour
{
    [SerializeField]
    private float BulletSpeed;
    [SerializeField]
    private Rigidbody2D bulletRB;
    public bool up;
    TimeManager timeManager;

    

    void Start()
    {
        //ScriptableObject.CreateInstance("Points");
        timeManager = new TimeManager();
        bulletRB = GetComponent<Rigidbody2D>();     
        bulletRB.gravityScale = 0.0f;
        bulletRB.mass = 0.1f;
        BulletSpeed = 10;
        bulletRB.velocity = transform.right * BulletSpeed;
        up = false;
        Destroy(gameObject, 3f);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
           
        if (collision.tag == ("Enemy"))
        {
            
            // points.points++;
            Destroy(gameObject);
            //animacion
            Destroy(collision.gameObject);
            //animacion
        }
        
        
    }

   
}

  

