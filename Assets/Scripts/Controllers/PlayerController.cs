using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controla las acciones del jugador
/// <JoystickAxes>Controla el movimiento del jugador con los joysticks, 
/// velocidad y posicion </JoystickAxes>
/// <MovementAxis>Asigna los ejes de movimiento al joystick i 
/// la velocidad del jugador</MovementAxis>
/// <PlayerShoot>Controla la accion de disparar </PlayerShoot>
/// <IsFiring>Comprueba si el jugador esta disparando, se utiliza en el boton del GUI</IsFiring>
/// </summary>
public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerManager playerManager;
    [SerializeField] [Range(0.1f, 20f)] private float movementSpeed;
    [SerializeField] [Range(0.1f, 1f)] private float firerate;
    [SerializeField] private int playerLife;
    [SerializeField] private Joystick joystick;
    [SerializeField] private GameObject bulletObj;
    [SerializeField] private Transform bulletSpawn, bulletSpawn2, bulletSpawn3;

    private Rigidbody2D playerRb;
    private float verticalMovement, horizontalMovement;
    private bool firing;
    private float nextFire;
    private float fireRate;
    private bool spawnFiring;

    //getters y setters
    public float VerticalMovement { get => verticalMovement; set => verticalMovement = value; }
    public bool Firing { get => firing; set => firing = value; }
    public Rigidbody2D PlayerRb { get => playerRb; set => playerRb = value; }
    public bool SpawnFiring { get => spawnFiring; set => spawnFiring = value; }
    public Transform BulletSpawn { get => bulletSpawn; set => bulletSpawn = value; }
    public Transform BulletSpawn2 { get => bulletSpawn2; set => bulletSpawn2 = value; }
    public Transform BulletSpawn3 { get => bulletSpawn3; set => bulletSpawn3 = value; }
    public float FireRate { get => fireRate; set => fireRate = value; }
    public float MovementSpeed { get => MovementSpeed1; set => MovementSpeed1 = value; }
    public float MovementSpeed1 { get => movementSpeed; set => movementSpeed = value; }

    void Start()
    {
        PlayerRb = GetComponent<Rigidbody2D>();
        playerManager.PlayerLife = playerLife;
        FireRate = 0.20f;
        JoystickAxes();
        movementsAxis(); 
    }
    void FixedUpdate()
    {
        PlayerShoot();
    }
    private void JoystickAxes()
    {
        if (joystick.Horizontal > 0.2f)
        {
            horizontalMovement *= MovementSpeed;
        }
        else if (joystick.Horizontal <= -0.2f)
        {
            horizontalMovement *= -MovementSpeed;
        }
        else
        {
            horizontalMovement = 0;

        }
        if (joystick.Vertical >= 0.2f)
        {
            VerticalMovement *= MovementSpeed;
        }
        else if (joystick.Vertical <= -0.2f)
        {
            VerticalMovement *= -MovementSpeed;
        }
        else
        {
            VerticalMovement = 0;
        }
    }
    private void movementsAxis()
    {
        horizontalMovement = joystick.Horizontal;
        verticalMovement = joystick.Vertical;
        Vector2 movement = new Vector2(horizontalMovement, verticalMovement);
        PlayerRb.velocity = movement * MovementSpeed;
    }
    public void PlayerShoot()
    {

        if (Firing && Time.time > nextFire && !SpawnFiring)
        {
            nextFire = Time.time + FireRate;
            Instantiate(bulletObj, BulletSpawn.position, BulletSpawn.rotation);
        }
        Firing = false;

    }
    public void PlayerShoot(float newFirerate,bool isEnabled)
    {

        if (Firing && Time.time > nextFire && !SpawnFiring && isEnabled)
        {
            nextFire = Time.time + newFirerate;
            Instantiate(bulletObj, BulletSpawn.position, BulletSpawn.rotation);
        }
        Firing = false;

    }
    public void PlayerShoot(bool isEnabled)
    {

        if (Firing && Time.time > nextFire && !SpawnFiring && isEnabled)
        {
            nextFire = Time.time + FireRate;
           Instantiate(bulletObj, BulletSpawn.position, BulletSpawn.rotation);
            
        }
        Firing = false;

    }
    public void IsFiring()
    {
        this.firing = true;
    }
}
