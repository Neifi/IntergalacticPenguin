using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotUlti : UnityEngine.MonoBehaviour
{
    float couldDown;//secs
    bool firing;
    public float fireRate;
    public Transform spawn;
    [SerializeField] private GameObject ulti;
    Quaternion spawnRotation;
    TimeManager timeManager;
   

    void Start()
    {
        timeManager = new TimeManager();
        firing = false;
        
        spawn = GetComponent<Transform>();
        
    }
    private void Update()
    {
        Shoot();
        timeManager.Update();
       
    }

    public void IsFiring()
    {
        firing = true;
            
    }
       
    public void Shoot()
    {
        spawnRotation = Quaternion.identity;
        if (firing && Time.time > couldDown)
        {
        timeManager.DoSlowmotion();
            couldDown = Time.time + fireRate;
            Instantiate(ulti, spawn.position, spawn.rotation);
        }
        firing = false;
 
    }

}
