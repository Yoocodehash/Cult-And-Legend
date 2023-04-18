/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToxicPlayerController : MonoBehaviour
{


    public float moveSpeed = 5f; // Speed at which the player moves
    public int maxHealth = 100; // Maximum health of the player
    public int currentHealth = 100; // Current health of the player
    public float toxicDamageRate = 5f; // Rate at which the player damages enemies with toxic damage

    public GameObject toxicProjectilePrefab; // Prefab for the toxic projectile
    public Transform projectileSpawnPoint; // Point where the projectile spawns
    public float projectileSpeed = 10f; // Speed at which the projectile moves
    public float projectileDelay = 0.5f; // Delay between projectile attacks

    private Rigidbody rb; // Rigidbody component of the player
    private Vector3 movementInput; // Input vector for movement
    private bool isAttacking = false; // Flag indicating whether the player is currently attacking
    private float attackTimer = 0f; // Timer to keep track of when to attack next

    void Start()
    {
        // Get the Rigidbody component
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get movement input
        movementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));

        if (!isAttacking)
        {
            // Move the player based on movement input
            rb.velocity = movementInput * moveSpeed;

            // Rotate the player to face the movement direction
            if (movementInput.magnitude > 0.1f)
            {
                transform.rotation = Quaternion.LookRotation(movementInput, Vector3.up);
            }

            // Check if the player is attacking
            if (Input.GetButton("Fire1"))
            {
                // Start attacking
                isAttacking = true;
                attackTimer = projectileDelay;
            }
        }
        else
        {
            // Wait for the projectile attack delay timer to finish
            attackTimer -= Time.deltaTime;
            if (attackTimer <= 0f)
            {
                // Spawn a projectile
                GameObject projectile = Instantiate(toxicProjectilePrefab, projectileSpawnPoint.position, Quaternion.identity);
                Rigidbody projectileRigidbody = projectile.GetComponent<Rigidbody>();
                projectileRigidbody.velocity = transform.forward * projectileSpeed;

                // Reset the attack timer and flag
                attackTimer = projectileDelay;
                isAttacking = false;
            }
        }
    }

    public void TakeDamage(int damage)
    {
        // Reduce the player's health
        currentHealth -= damage;

        // Check if the player has been defeated
        if (currentHealth <= 0)
        {
            // TODO: Implement defeat logic
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Apply toxic damage to the enemy on collision
            EnemyController enemy = other.GetComponent<EnemyController>();
            enemy.TakeDamage((int)(toxicDamageRate * Time.deltaTime));
        }
    }


}

*/