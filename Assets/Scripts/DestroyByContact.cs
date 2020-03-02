using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyByContact : UnityEngine.MonoBehaviour {
    public GameObject bonus;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boundary")
        {
            Destroy(gameObject);
        }

        if (other.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(bonus);
            
        }
        if (other.tag == "Bullet")
        {
            Destroy(bonus);
            Destroy(other.gameObject);
        }
    }

}
