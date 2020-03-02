using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBonus : MonoBehaviour
{

    private bool isEnabled;
    public float seconds = 2;
    bool spawnFiring = false;
    [SerializeField] private GameObject bulletObj;
    PlayerController playerController;
    private void Start()
    {
        isEnabled = false;
        playerController = new PlayerController();
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

        spawnFiring = true;
        GetComponent<SpriteRenderer>().enabled = false;
        GetComponent<Collider2D>().enabled = false;
        StartCoroutine(FireSpawn(Player));


        yield return new WaitForSeconds(seconds);
        playerController.SpawnFiring = false;
        Destroy(gameObject);
    }
    IEnumerator FireSpawn(Collider2D Player)
    {
        PlayerManager fire = Player.GetComponent<PlayerManager>();
        while (spawnFiring)//bonus
        {
            isEnabled = true;
            playerController.PlayerShoot(isEnabled);
            yield return new WaitForSeconds(0.6f);

        }
        isEnabled = false;
    }
}

