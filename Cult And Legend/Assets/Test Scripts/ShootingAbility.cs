using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAbility : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public int damage = 10;
    public float range = 100f;
    public float fireRate = 0.1f;
    public AudioClip soundEffect;

    private float cooldownTimer = 0f;

    public void Activate()
    {
        if (cooldownTimer <= 0f)
        {
            // Fire a bullet, play a sound, etc.
            cooldownTimer = fireRate;
        }
    }


    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

    }
}
