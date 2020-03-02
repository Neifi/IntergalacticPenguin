using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName ="EnemyBullets")]
public class Enemy : UnityEngine.MonoBehaviour
{
    EnemyManager enemyManager;
    Transform bulletTransform;
    Bullets bullets;

    public GameObject bullet;
    Vector2 enemyPosition;
    public float fireRate;

    public void Awake()
    {
        bullet = new GameObject();
       
    }
   
    public IEnumerator BulletInstance(float fireRate)
    {
        enemyPosition = new Vector2(0f,0f);
        Quaternion bulletRotation =  Quaternion.identity;
       // instan(enemyManager.enemy, enemyPosition, bulletRotation);
       yield return new WaitForSeconds(2f);
    }

}
