using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [Header("References")]
    [SerializeField] private GameObject[] enemyPrefabs;

    [Header("Attributes")]
    [SerializeField] private int baseEnemies = 8;
    [SerializeField] private float enemyPerSecond = .5f;
    [SerializeField] private float timeBetweenWaves = 5f;

    private int currentWave = 1;
    private float timeSinceLastSpawn;
    private int enemiesAlive;
    private int enemiesLeftToSpawn;




    // Start is called before the first frame update
    void Start()
    {
        enemiesLeftToSpawn = baseEnemies;
    }

    private int EnemiesPerWave()
    {
        return Mathf.RoundToInt(baseEnemies * currentWave);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
