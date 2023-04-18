using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossManager : MonoBehaviour
{

    public int maxHealth = 1000;
    public float attackInterval = 2.0f;
    public float moveSpeed = 5.0f;
    public Animator animator;
    public GameObject victoryScreen;
    public GameObject gameOverScreen;

    private int currentHealth;
    private bool isDefeated = false;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (!isDefeated)
        {
            // Handle boss behavior here
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("TakeDamage");

        if (currentHealth <= 0)
        {
            isDefeated = true;
            animator.SetTrigger("Defeat");
            HandleVictory();
        }
    }

    private void HandleVictory()
    {
        victoryScreen.SetActive(true);
        // Add any other victory-related behavior here
    }

    public void HandleDefeat()
    {
        gameOverScreen.SetActive(true);
        // Add any other game over-related behavior here
    }



}
