using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : UnityEngine.MonoBehaviour
{
    public int speed;
    public Rigidbody2D enemy;
    private void FixedUpdate()
    {
        enemy.velocity = transform.right * -speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }



}
