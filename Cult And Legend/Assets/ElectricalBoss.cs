using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricalBoss : MonoBehaviour
{


    public int health = 100; // Electrical Boss's health

    public Transform[] targetPoints; // List of target points for the boss to move to
    private int currentTargetIndex = 0; // Index of the current target point
    public float movementSpeed = 5f; // Speed at which the boss moves

    public GameObject[] shockPoints; // List of points to send electrical shocks from
    public float shockDelay = 2f; // Delay between electrical shocks
    public float shockDuration = 0.5f; // Duration of each electrical shock

    private bool isShocking = false; // Flag indicating whether the boss is currently shocking
    private float shockTimer = 0f; // Timer to keep track of when to send the next electrical shock

    void Start()
    {
        // Set the starting position of the boss
        transform.position = targetPoints[currentTargetIndex].position;
    }

    void Update()
    {
        if (!isShocking)
        {
            // Move the boss towards the current target point
            transform.position = Vector3.MoveTowards(transform.position, targetPoints[currentTargetIndex].position, movementSpeed * Time.deltaTime);

            // Check if the boss has reached the current target point
            if (transform.position == targetPoints[currentTargetIndex].position)
            {
                // Set the next target point
                currentTargetIndex = (currentTargetIndex + 1) % targetPoints.Length;

                // Start shocking after reaching a target point
                isShocking = true;
                shockTimer = shockDelay;
            }
        }
        else
        {
            // Wait for the shock delay timer to finish
            shockTimer -= Time.deltaTime;
            if (shockTimer <= 0f)
            {
                // Send an electrical shock from each shock point
                foreach (GameObject shockPoint in shockPoints)
                {
                    StartCoroutine(SendElectricalShock(shockPoint));
                }

                // Reset the shock timer and flag
                shockTimer = shockDelay;
                isShocking = false;
            }
        }
    }

    IEnumerator SendElectricalShock(GameObject shockPoint)
    {
        // Activate the shock effect
        shockPoint.SetActive(true);

        // Wait for the shock duration
        yield return new WaitForSeconds(shockDuration);

        // Deactivate the shock effect
        shockPoint.SetActive(false);
    }

    public void TakeDamage(int damage)
    {
        // Reduce the boss's health
        health -= damage;

        // Check if the boss has been defeated
        if (health <= 0)
        {
            // TODO: Implement boss defeat logic
        }
    }


}
