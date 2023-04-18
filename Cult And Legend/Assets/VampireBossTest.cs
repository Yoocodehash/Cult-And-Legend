using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VampireBossTest : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float attackRange = 10.0f;
    public float attackCooldown = 2.0f;
    public GameObject player;
    public GameObject projectilePrefab;
    public GameObject minionPrefab;

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

    public void SpawnMinions()
    {
        for (int i = 0; i < 3; i++)
        {
            Vector3 minionPos = transform.position + new Vector3(Random.Range(-2.0f, 2.0f), 0, Random.Range(-2.0f, 2.0f));
            GameObject minion = Instantiate(minionPrefab, minionPos, Quaternion.identity);
        }
    }

    public void MeleeAttack()
    {
        // Code to perform melee attack
    }

}
