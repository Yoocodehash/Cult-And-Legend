/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBoss : MonoBehaviour
{


    public int health = 100; // Fire Boss's health

    public Transform[] targetPoints; // List of target points for the boss to move to
    private int currentTargetIndex = 0; // Index of the current target point
    public float movementSpeed = 5f; // Speed at which the boss moves

    public GameObject fireBallPrefab; // Prefab for the fireball projectile
    public Transform fireBallSpawnPoint; // Point where fireball spawns
    public float fireBallSpeed = 10f; // Speed at which the fireball moves
    public float fireBallDelay = 2f; // Delay between fireball attacks

    private bool isAttacking = false; // Flag indicating whether the boss is currently attacking
    private float attackTimer = 0f; // Timer to keep track of when to attack next

    void Start()
    {
        // Set the starting position of the boss
        transform.position = targetPoints[currentTargetIndex].position;
    }

    void Update()
    {
        if (!isAttacking)
        {
            // Move the boss towards the current target point
            transform.position = Vector3.MoveTowards(transform.position, targetPoints[currentTargetIndex].position, movementSpeed * Time.deltaTime);

            // Check if the boss has reached the current target point
            if (transform.position == targetPoints[currentTargetIndex].position)
            {
                // Set the next target point
                currentTargetIndex = (currentTargetIndex + 1) % targetPoints.Length;

                // Start attacking after reaching a target point
                isAttacking = true;
                attackTimer = fireBallDelay;
            }
        }
        else
        {
            // Wait for the fireball attack delay timer to finish
            attackTimer -= Time.deltaTime;
            if (attackTimer <= 0f)
            {
                // Spawn a fireball projectile
                GameObject fireBall = Instantiate(fireBallPrefab, fireBallSpawnPoint.position, Quaternion.identity);
                Rigidbody fireBallRigidbody = fireBall.GetComponent<Rigidbody>();
                fireBallRigidbody.velocity = (PlayerController.instance.transform.position - fireBallSpawnPoint.position).normalized * fireBallSpeed;

                // Reset the attack timer and flag
                attackTimer = fireBallDelay;
                isAttacking = false;
            }
        }
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

*/