using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] powerUps;

    private GameObject[] enemiesSpawnPoints;
    private GameObject[] powerUpsSpawnPoints;

    // Start is called before the first frame update
    void Start()
    {
        enemiesSpawnPoints = GameObject.FindGameObjectsWithTag("EnemySpawn");
        powerUpsSpawnPoints = GameObject.FindGameObjectsWithTag("PowerUpSpawn");

        foreach (var enemySpawnIndex in enemiesSpawnPoints)
        {
            SpawnObject(RandomGameObjectIndex(enemies), enemySpawnIndex);
        }
        foreach (var powerUpSpawnIndex in powerUpsSpawnPoints)
        {
            SpawnObject(RandomGameObjectIndex(powerUps), powerUpSpawnIndex);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnObject( GameObject objectToSpawn, GameObject atObject)
    {
        Instantiate(objectToSpawn, atObject.transform);
    }

    private GameObject RandomGameObjectIndex(GameObject[] tableau)
    {
        return tableau[Random.Range(0, tableau.Length)];
    }
}
