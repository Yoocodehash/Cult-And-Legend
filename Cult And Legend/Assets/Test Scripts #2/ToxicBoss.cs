/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicBoss : MonoBehaviour
{


    public int health = 100; // Toxic Boss's health

    public Transform[] targetPoints; // List of target points for the boss to move to
    private int currentTargetIndex = 0; // Index of the current target point
    public float movementSpeed = 5f; // Speed at which the boss moves

    public GameObject toxicProjectilePrefab; // Prefab for the toxic projectile
    public Transform toxicProjectileSpawnPoint; // Point where the toxic projectile spawns
    public float toxicProjectileSpeed = 10f; // Speed at which the toxic projectile moves
    public float toxicProjectileDelay = 2f; // Delay between toxic projectile attacks

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
                attackTimer = toxicProjectileDelay;
            }
        }
        else
        {
            // Wait for the toxic projectile attack delay timer to finish
            attackTimer -= Time.deltaTime;
            if (attackTimer <= 0f)
            {
                // Spawn a toxic projectile
                GameObject toxicProjectile = Instantiate(toxicProjectilePrefab, toxicProjectileSpawnPoint.position, Quaternion.identity);
                Rigidbody toxicProjectileRigidbody = toxicProjectile.GetComponent<Rigidbody>();
                toxicProjectileRigidbody.velocity = (PlayerController.instance.transform.position - toxicProjectileSpawnPoint.position).normalized * toxicProjectileSpeed;

                // Reset the attack timer and flag
                attackTimer = toxicProjectileDelay;
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Apply toxic damage to the player on collision
            PlayerController.instance.TakeDamage(5);
        }
    }


}

*/