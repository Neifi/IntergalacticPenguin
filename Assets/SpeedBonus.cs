using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBonus : UnityEngine.MonoBehaviour
{

    public float speedUp = 2;
    float  seconds = 2;


   
    void OnTriggerEnter2D(Collider2D other)
     {
        if (other.tag==("Player"))
        {
            StartCoroutine(PickUp(other));
            
        } 
      }

     IEnumerator PickUp(Collider2D Player)
     {
        //efecto to guapo xde
        PlayerController speed = Player.GetComponent<PlayerController>();
         speed.MovementSpeed += speedUp;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
         yield return new WaitForSeconds(seconds);
         speed.MovementSpeed -= speedUp;
         Destroy(gameObject);
    }

}



