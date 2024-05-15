using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnerController : MonoBehaviour
{
    public GameObject genericEnemyPrefab;

    private float startSpawn = 1.0f;
    private float repeatSpawn = 5.0f;
    private int enemiesToSpawn = 2;

    void Start()
    {
        InvokeRepeating(nameof(SpawnGenericEnemies), startSpawn, repeatSpawn);
    }

    void Update()
    {
        
    }

    public void SpawnGenericEnemies()
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(genericEnemyPrefab, GenerateGenericEnemySpawnLocation(), genericEnemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateGenericEnemySpawnLocation()
    {
        return new Vector3(Random.Range(-GlobalVariables.leftRight, GlobalVariables.leftRight), GlobalVariables.height, GlobalVariables.top);
    }

    public void StopSpawning()
    {
        CancelInvoke();
    }

}
