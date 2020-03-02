using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class direc : UnityEngine.MonoBehaviour
{
    int speed;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

            transform.position = Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y),
            target.position, speed * Time.deltaTime);//seguimiento del jugador en ambos ejes

        
    }
}
