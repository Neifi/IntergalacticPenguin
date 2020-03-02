using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : UnityEngine.MonoBehaviour {

    
    
    // Use this for initialization
    public float speed = 4;
    public Transform target;
    public int distance;

     void Start()
    {
       
    }
    void FixedUpdate()
    {
        
        transform.position = Vector2.MoveTowards(new Vector2(5,transform.position.y), target.position, speed * Time.deltaTime);
        


    }
}
