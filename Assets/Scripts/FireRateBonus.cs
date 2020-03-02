using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRateBonus : UnityEngine.MonoBehaviour
{

    [SerializeField] public float fireSpeed = 0.7f;
    [SerializeField] public float fireSpeedOri = 0.15f;
    [SerializeField] public float seconds = 4; 
    PlayerController playerController;


    private void Start()
    {
        playerController = GetComponent<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == ("Player"))
        {
            StartCoroutine(PickUp(other));
    
        }
    }

    IEnumerator PickUp(Collider2D Player)
    {
        //efecto to guapo xde
        playerController.FireRate -= fireSpeed;
        GetComponent<Collider2D>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;

        yield return new WaitForSeconds(seconds);
        playerController.FireRate = fireSpeedOri;
        Destroy(gameObject);
    }
}
