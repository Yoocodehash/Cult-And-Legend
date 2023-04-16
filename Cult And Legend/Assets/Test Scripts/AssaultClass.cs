using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssaultClass : MonoBehaviour
{

    public int maxHealth = 100;
    public int damageOutput = 10;
    public float movementSpeed = 5f;
    public AudioClip soundEffect;

    private int currentHealth;

    public void ActivateAbility()
    {
        // Use the assault class's unique ability
    }

    public int GetHealth()
    {
        return currentHealth;
    }


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        // Handle any gameplay mechanics specific to the assault class
    }
}
