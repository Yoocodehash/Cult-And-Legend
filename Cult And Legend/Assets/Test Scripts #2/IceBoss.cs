/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceBoss : MonoBehaviour
{


    public int health = 100; // Ice Boss's health

    public Transform[] targetPoints; // List of target points for the boss to move to
    private int currentTargetIndex = 0; // Index of the current target point
    public float movementSpeed = 5f; // Speed at which the boss moves

    public GameObject iceProjectilePrefab; // Prefab for the ice projectile
    public Transform iceProjectileSpawnPoint; // Point where the ice projectile spawns
    public float iceProjectileSpeed = 10f; // Speed at which the ice projectile moves
    public float iceProjectileDelay = 2f; // Delay between ice projectile attacks

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
                attackTimer = iceProjectileDelay;
            }
        }
        else
        {
            // Wait for the ice projectile attack delay timer to finish
            attackTimer -= Time.deltaTime;
            if (attackTimer <= 0f)
            {
                // Spawn an ice projectile
                GameObject iceProjectile = Instantiate(iceProjectilePrefab, iceProjectileSpawnPoint.position, Quaternion.identity);
                Rigidbody iceProjectileRigidbody = iceProjectile.GetComponent<Rigidbody>();
                iceProjectileRigidbody.velocity = (PlayerController.instance.transform.position - iceProjectileSpawnPoint.position).normalized * iceProjectileSpeed;

                // Reset the attack timer and flag
                attackTimer = iceProjectileDelay;
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