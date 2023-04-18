using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WerewolfBossTest : MonoBehaviour
{


    public float moveSpeed = 5.0f;
    public float attackRange = 10.0f;
    public float attackCooldown = 2.0f;
    public GameObject player;
    public GameObject projectilePrefab;
    public GameObject clawPrefab;
    public GameObject roarPrefab;

    private Animator animator;
    private bool isAttacking = false;
    private float lastAttackTime = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        if (distanceToPlayer <= attackRange && !isAttacking && Time.time > lastAttackTime + attackCooldown)
        {
            isAttacking = true;
            lastAttackTime = Time.time;

            int attackType = Random.Range(1, 4);
            animator.SetInteger("AttackType", attackType);
            animator.SetTrigger("Attack");
        }
        else if (distanceToPlayer > attackRange)
        {
            isAttacking = false;
            animator.SetBool("Moving", true);
            transform.LookAt(player.transform.position);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
        else
        {
            animator.SetBool("Moving", false);
        }
    }

    public void AttackEnd()
    {
        isAttacking = false;
    }

    public void ShootProjectile()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position + transform.forward * 2.0f, Quaternion.identity);
        projectile.GetComponent<Rigidbody>().velocity = transform.forward * 10.0f;
    }

    public void ClawAttack()
    {
        GameObject claw = Instantiate(clawPrefab, transform.position + transform.forward * 2.0f, Quaternion.identity);
        claw.GetComponent<Rigidbody>().velocity = transform.forward * 10.0f;
    }

    public void RoarAttack()
    {
        GameObject roar = Instantiate(roarPrefab, transform.position, Quaternion.identity);
        Destroy(roar, 2.0f);
    }


}
