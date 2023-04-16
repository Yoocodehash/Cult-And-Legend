/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    


    public WaveDefinition[] waves;
    public Transform[] spawnPoints;

    private int currentWave = 0;
    private float waveStartTime = 0f;
    private bool waveStarted = false;

    private void Update()
    {
        if (!waveStarted && Time.time - waveStartTime >= waves[currentWave].delay)
        {
            StartWave();
        }
    }

    private void StartWave()
    {
        waveStarted = true;
        foreach (EnemyDefinition enemyDef in waves[currentWave].enemies)
        {
            for (int i = 0; i < enemyDef.count; i++)
            {
                GameObject enemy = Instantiate(enemyDef.prefab, GetRandomSpawnPoint(), Quaternion.identity);
            }
        }
    }

    private Vector3 GetRandomSpawnPoint()
    {
        return spawnPoints[Random.Range(0, spawnPoints.Length)].position;
    }


}

*/