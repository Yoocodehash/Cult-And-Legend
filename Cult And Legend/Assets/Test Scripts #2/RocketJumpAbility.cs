/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketJumpAbility : MonoBehaviour
{

    public float jumpForce = 10.0f;
    public float jumpRadius = 5.0f;
    public float jumpDamage = 50.0f;
    public float jumpKnockback = 5.0f;
    public LayerMask enemyLayer;

    private bool isRocketJumping = false;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (!isRocketJumping && Input.GetButtonDown("RocketJump"))
        {
            RocketJump();
        }
    }

    private void RocketJump()
    {
        isRocketJumping = true;

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);

        Collider[] colliders = Physics.OverlapSphere(transform.position, jumpRadius, enemyLayer);

        foreach (Collider collider in colliders)
        {
            Enemy enemy = collider.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.TakeDamage(jumpDamage);
                enemy.Knockback(transform.forward * jumpKnockback);
            }
        }

        StartCoroutine(EndRocketJump());
    }

    private IEnumerator EndRocketJump()
    {
        yield return new WaitForSeconds(2.0f);

        isRocketJumping = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (isRocketJumping && enemyLayer == (enemyLayer | (1 << collision.gameObject.layer)))
        {
            Enemy enemy = collision.gameObject.GetComponent<Enemy>();

            if (enemy != null)
            {
                enemy.TakeDamage(jumpDamage);
                enemy.Knockback(transform.forward * jumpKnockback);
            }
        }
    }

}

*/