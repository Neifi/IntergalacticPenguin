using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    [TextArea]
    [Tooltip("ToDo")]
    public string Notes; 


    private GameObject[] powerUps;

    private GameObject[] asteroidsA;

    private GameObject[] enemy;

    public Vector3 spawnValues;


    public float tiempoCadaOleada;//tiempo entre cada oleada

    public float tiempoPreparacion;//tiempo antes de empezar las hordas


    public GameObject speedBonus;
    public GameObject fireRateBonus;
    public GameObject tripleSpawnBonus;

    public int bonusPorOleada;//numero de bonus en una oleada
    public float tiempoSpawnCadaBonus;//tiempo de spawn  cada bonus

    public int enemyPorOleada;//numero de enemigos en una oleada
    public float tiempoSpawnEnemigo;//tiempo de spawn de cada enemigo

    public float shooterPorOleada;
    public float tiempoSpawnShooter;

    public GameObject asteroidA1;
    public GameObject asteroidA2;
    public GameObject asteroidA3;

    public GameObject enemy0;
    public GameObject enemy1;

    public int asteroidesOleada;//numero de enemigos en una oleada

    public float tiempoSpawnCadaAsteroide;//tiempo de spawn cada asteroides


    private Points points;

    public Text pointText;

    Enemy enemyScript;
    public Vector2[] spawnPosition;
    public void DisplayPoints()
    {
        // pointText.text = (Points.ToString());
    }
    private void Start()
    {
        Notes = "ToDo List";
        points = new Points();
        //powerUps
        powerUps = new GameObject[3];
        powerUps[0] = speedBonus;
        powerUps[1] = fireRateBonus;
        powerUps[2] = tripleSpawnBonus;
        //Asteroides A
        asteroidsA = new GameObject[3];
        asteroidsA[0] = asteroidA1;
        asteroidsA[1] = asteroidA2;
        asteroidsA[2] = asteroidA3;
        //
        enemy = new GameObject[2];
        enemy[0] = enemy0;
        enemy[1] = enemy1;
        //
        StartCoroutine(SpawnBonusWaves());
        StartCoroutine(SpawnEnemyWaves());
        StartCoroutine(SpawnAsteroidsA());
        StartCoroutine(SpawnShooterWaves());
        //

        spawnPosition = new Vector2[5];
        spawnPosition[0] = new Vector2(10, 4);
        spawnPosition[1] = new Vector2(10, 2);
        spawnPosition[2] = new Vector2(10, 0);
        spawnPosition[3] = new Vector2(10, -2);
        spawnPosition[4] = new Vector2(10, -4);


    }

    private void Update()
    {
        

    }


    private IEnumerator SpawnEnemyWaves()
    {
        yield return new WaitForSeconds(tiempoPreparacion);

        while (true)
        {
            for (int i = 0; i < enemyPorOleada; i++)
            {
               
                Quaternion spawnRotation = Quaternion.identity;//identy = sin rotancion
                Instantiate(enemy[1], spawnPosition[Random.Range(0,5)], spawnRotation);
                yield return new WaitForSeconds(tiempoSpawnEnemigo);
            }
            yield return new WaitForSeconds(tiempoCadaOleada);

        }
    }

    private IEnumerator SpawnBonusWaves()
    {
        yield return new WaitForSeconds(tiempoPreparacion);
        while (true)
        {
            for (int x = 0; x < bonusPorOleada; x++)
            {
               
                Quaternion spawnRotation = Quaternion.identity;//identy = sin rotancion
                Instantiate(powerUps[Random.Range(0, 3)], spawnPosition[Random.Range(0,5)], spawnRotation);
                yield return new WaitForSeconds(tiempoSpawnCadaBonus);
            }
            yield return new WaitForSeconds(tiempoCadaOleada);
        }
    }

    private IEnumerator SpawnAsteroidsA()
    {
        yield return new WaitForSeconds(tiempoPreparacion);
        while (true)
        {
            for (int x = 0; x < asteroidesOleada; x++)
            {
                
                Quaternion spawnRotation = Quaternion.identity;//identy = sin rotancion
                Instantiate(asteroidsA[0], spawnPosition[Random.Range(0,5)], spawnRotation);
                yield return new WaitForSeconds(tiempoSpawnCadaAsteroide);
            }
            yield return new WaitForSeconds(tiempoCadaOleada);
        }
    }

    private IEnumerator SpawnShooterWaves()
    {
        yield return new WaitForSeconds(tiempoPreparacion);

        while (true)
        {
            for (int i = 0; i < shooterPorOleada; i++)
            {

                Quaternion spawnRotation = Quaternion.identity;//identy = sin rotancion
                Instantiate(enemy[0], spawnPosition[Random.Range(0, 5)], spawnRotation);
                yield return new WaitForSeconds(tiempoSpawnShooter);
            }
            yield return new WaitForSeconds(tiempoCadaOleada);

        }
    }



}

