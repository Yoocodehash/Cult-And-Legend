/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{

    public BossDefinition boss;
    public Transform spawnPoint;

    private bool spawned = false;



    // Start is called before the first frame update
    void Start()
    {

    }



    private void Update()
    {
        if (!spawned && PlayerReachedBossSpawnPoint())
        {
            SpawnBoss();
        }
    }

    private bool PlayerReachedBossSpawnPoint()
    {
        // Check if the player has reached the boss spawn point
    }

    private void SpawnBoss()
    {
        GameObject bossObj = Instantiate(boss.prefab, spawnPoint.position, Quaternion.identity);
        bossObj.GetComponent<Health>().maxHealth = boss.maxHealth;
        bossObj.GetComponent<AI>().attackInterval = boss.attackInterval;
        bossObj.GetComponent<AI>().moveSpeed = boss.moveSpeed;
        // Add any other necessary components or behaviors
        spawned = true;
    }


}

*/