/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMode : MonoBehaviour
{

    public GameObject[] zombiePrefabs;
    public Transform[] spawnPoints;
    public float spawnInterval = 3f;
    public int maxZombies = 10;

    private int currentZombies = 0;
    private float timeSinceLastSpawn = 0f;

    void Update()
    {
        if (currentZombies < maxZombies)
        {
            timeSinceLastSpawn += Time.deltaTime;
            if (timeSinceLastSpawn >= spawnInterval)
            {
                SpawnZombie();
                timeSinceLastSpawn = 0f;
            }
        }
    }

    void SpawnZombie()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        int zombieIndex = Random.Range(0, zombiePrefabs.Length);
        GameObject newZombie = Instantiate(zombiePrefabs[zombieIndex], spawnPoints[spawnIndex].position, Quaternion.identity);
        newZombie.GetComponent<ZombieAI>().target = GameObject.FindGameObjectWithTag("Player").transform;
        currentZombies++;
    }

    public void KillZombie()
    {
        currentZombies--;
    }


}

*/