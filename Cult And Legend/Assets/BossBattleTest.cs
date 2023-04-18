/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBattleTest : MonoBehaviour
{


    public GameObject bossPrefab;
    public Transform bossSpawnPoint;
    public float bossSpawnDelay = 2f;
    public int bossHealth = 100;
    public int bossDamage = 10;
    public float bossAttackDelay = 1f;
    public float bossSpeed = 5f;

    private GameObject currentBoss;
    private bool isBossActive = false;

    void Start()
    {
        StartCoroutine(SpawnBoss());
    }

    void Update()
    {
        if (isBossActive)
        {
            // Boss movement and attack logic goes here
        }
    }

    IEnumerator SpawnBoss()
    {
        yield return new WaitForSeconds(bossSpawnDelay);
        currentBoss = Instantiate(bossPrefab, bossSpawnPoint.position, bossSpawnPoint.rotation);
        currentBoss.GetComponent<EnemyHealth>().SetHealth(bossHealth);
        currentBoss.GetComponent<EnemyAttack>().SetDamage(bossDamage);
        currentBoss.GetComponent<EnemyAttack>().SetAttackDelay(bossAttackDelay);
        currentBoss.GetComponent<EnemyMovement>().SetSpeed(bossSpeed);
        isBossActive = true;
    }

    public void EndBossBattle()
    {
        // Cleanup logic goes here
        isBossActive = false;
        Destroy(currentBoss);
    }



}

*/