using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : UnityEngine.MonoBehaviour {

    public Rigidbody2D bonusRb;
    public int speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        bonusRb.velocity = transform.right * -speed;
    }
}
