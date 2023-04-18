/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeAbility : MonoBehaviour
{

    public float chargeSpeed = 10.0f;
    public float chargeDuration = 1.0f;
    public float chargeCooldown = 5.0f;
    public float chargeDamage = 50.0f;
    public float chargeKnockback = 5.0f;
    public LayerMask enemyLayer;

    private bool isCharging = false;
    private bool isOnCooldown = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isCharging && !isOnCooldown && Input.GetButtonDown("Charge"))
        {
            StartCoroutine(Charge());
        }
    }

    private IEnumerator Charge()
    {
        isCharging = true;

        rb.velocity = transform.forward * chargeSpeed;

        yield return new WaitForSeconds(chargeDuration);

        rb.velocity = Vector3.zero;

        isCharging = false;
        isOnCooldown = true;

        yield return new WaitForSeconds(chargeCooldown);

        isOnCooldown = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isCharging && enemyLayer == (enemyLayer | (1 << collision.gameObject.layer)))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.TakeDamage(chargeDamage);
                enemy.Knockback(transform.forward * chargeKnockback);
            }
        }
    }


}

*/