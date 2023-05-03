/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserAbility : MonoBehaviour
{


    public float laserDuration = 3.0f; // The duration of the laser in seconds
    public float laserDamage = 10.0f; // The amount of damage the laser does per second
    public GameObject laserPrefab; // The prefab for the laser beam
    public Transform laserSpawnPoint; // The transform for the laser spawn point

    private bool isFiring = false; // Whether the laser is currently firing
    private LineRenderer laserLine; // The line renderer for the laser beam
    private float laserTimer = 0.0f; // The current time the laser has been firing

    void Start()
    {
        // Get the line renderer component from the laser prefab
        laserLine = laserPrefab.GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isFiring)
        {
            // Start firing the laser
            isFiring = true;
            laserTimer = 0.0f;

            // Enable the line renderer for the laser beam
            laserLine.enabled = true;

            // Set the initial position of the laser beam
            laserLine.SetPosition(0, laserSpawnPoint.position);
            laserLine.SetPosition(1, laserSpawnPoint.position);
        }

        if (isFiring)
        {
            // Update the timer for the laser
            laserTimer += Time.deltaTime;

            // Check if the laser has finished firing
            if (laserTimer >= laserDuration)
            {
                // Stop firing the laser
                isFiring = false;

                // Disable the line renderer for the laser beam
                laserLine.enabled = false;
            }
            else
            {
                // Update the position of the laser beam
                RaycastHit hit;
                if (Physics.Raycast(laserSpawnPoint.position, laserSpawnPoint.forward, out hit))
                {
                    laserLine.SetPosition(1, hit.point);

                    // Damage the hit object if it has a health component
                    Health health = hit.collider.GetComponent<Health>();
                    if (health != null)
                    {
                        health.TakeDamage(laserDamage * Time.deltaTime);
                    }
                }
                else
                {
                    laserLine.SetPosition(1, laserSpawnPoint.position + laserSpawnPoint.forward * 1000);
                }
            }
        }
    }

}

*/