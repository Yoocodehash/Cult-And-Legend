/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public float attackCooldown = 2f; // Time between attacks
    public float attackRange = 10f; // Maximum attack range
    public int attackDamage = 10; // Damage dealt per attack
    public GameObject attackEffect; // Effect to play when attacking

    private Transform target; // The target to attack (player)
    private float lastAttackTime; // Time when the boss last attacked

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform; // Find the player object
    }

    void Update()
    {
        // Check if the player is in range and the attack cooldown has passed
        if (Vector3.Distance(transform.position, target.position) <= attackRange && Time.time > lastAttackTime + attackCooldown)
        {
            // Attack the player
            target.GetComponent<PlayerHealth>().TakeDamage(attackDamage); // Damage the player
            Instantiate(attackEffect, target.position, Quaternion.identity); // Play the attack effect
            lastAttackTime = Time.time; // Record the time of the attack
        }
    }
}

*/