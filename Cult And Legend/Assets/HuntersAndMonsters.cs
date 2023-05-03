/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class HuntersAndMonsters : MonoBehaviour
{

        public GameObject[] gardens;
    public GameObject[] graveyards;
    public GameObject[] plantSpawners;
    public GameObject[] zombieSpawners;
    public GameObject[] plantPlayers;
    public GameObject[] zombiePlayers;
    public GameObject[] plants;
    public GameObject[] zombies;
    public Text statusText;
    public float spawnDelay = 5.0f;
    public int gardenCapturePoints = 3;
    public int zombieTickets = 50;
    public int plantTickets = 50;

    private bool gameOver = false;
    private bool gameStarted = false;
    private int zombieCapturePoints = 0;
    private int plantCapturePoints = 0;
    private int plantTicketCounter = 0;
    private int zombieTicketCounter = 0;

    void Start()
    {
        // Initialize game state
        foreach (GameObject garden in gardens)
        {
            garden.GetComponent<GardenCapturePoint>().OnCapture += GardenCaptured;
        }
        foreach (GameObject graveyard in graveyards)
        {
            graveyard.GetComponent<GraveyardCapturePoint>().OnCapture += GraveyardCaptured;
        }
        statusText.text = "Waiting for players...";
    }

    void Update()
    {
        // Check if game over
        if (gameOver)
        {
            return;
        }

        // Check if game started
        if (!gameStarted)
        {
            if (plantPlayers.Length > 0 && zombiePlayers.Length > 0)
            {
                gameStarted = true;
                StartCoroutine(SpawnPlants());
                StartCoroutine(SpawnZombies());
                statusText.text = "Game started! Plants vs Zombies!";
            }
            return;
        }

        // Check if all gardens captured by plants
        if (plantCapturePoints == gardenCapturePoints)
        {
            GameOver("Plants Win!");
            return;
        }

        // Check if all graveyards captured by zombies
        if (zombieCapturePoints == gardenCapturePoints)
        {
            GameOver("Zombies Win!");
            return;
        }

        // Update plant tickets
        plantTicketCounter++;
        if (plantTicketCounter >= spawnDelay)
        {
            plantTicketCounter = 0;
            plantTickets++;
        }

        // Update zombie tickets
        zombieTicketCounter++;
        if (zombieTicketCounter >= spawnDelay)
        {
            zombieTicketCounter = 0;
            zombieTickets++;
        }

        // Check if plants or zombies out of tickets
        if (plantTickets <= 0)
        {
            GameOver("Zombies Win!");
            return;
        }
        if (zombieTickets <= 0)
        {
            GameOver("Plants Win!");
            return;
        }
    }

    void GardenCaptured(int team)
    {
        if (team == 1)
        {
            plantCapturePoints++;
        }
        else if (team == 2)
        {
            zombieCapturePoints++;
        }
    }

    void GraveyardCaptured(int team)
    {
        if (team == 1)
        {
            zombieCapturePoints++;
        }
        else if (team == 2)
        {
            plantCapturePoints++;
        }
    }

    IEnumerator SpawnPlants()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            if (plantTickets > 0)
            {
                GameObject spawner = plantSpawners[Random.Range(0, plantSpawners.Length)];
                GameObject plant = plants[Random.Range(0, plants.Length)];

                plantTickets--;
                Instantiate(plant, spawner.transform.position, spawner.transform.rotation);
            }
        }
    }

    IEnumerator SpawnZombies()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnDelay);
            if (zombieTickets > 0)
            {
                GameObject spawner = zombieSpawners[Random.Range(0, zombieSpawners.Length)];
                GameObject zombie = zombies[Random.Range(0, zombies.Length)];
                zombieTickets--;
                Instantiate(zombie, spawner.transform.position, spawner.transform.rotation);
            }
        }
    }

    void GameOver(string message)
    {
        gameOver = true;
        statusText.text = message;
    }




}


*/