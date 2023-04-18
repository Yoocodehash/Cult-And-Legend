using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAssaultClass : MonoBehaviour
{


    public float moveSpeed = 5.0f;
    public float jumpForce = 10.0f;
    public float attackRange = 10.0f;
    public float attackCooldown = 2.0f;
    public GameObject projectilePrefab;
    public GameObject meleePrefab;
    public GameObject bombPrefab;

    private Animator animator;
    private bool isAttacking = false;
    private float lastAttackTime = 0.0f;
    private bool isGrounded = true;
    private Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            animator.SetBool("Moving", true);
        }
        else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.position -= transform.forward * moveSpeed * Time.deltaTime;
            animator.SetBool("Moving", true);
        }
        else
        {
            animator.SetBool("Moving", false);
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

        float distanceToEnemy = Mathf.Infinity;
        GameObject closestEnemy = null;
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (distance < distanceToEnemy)
            {
                distanceToEnemy = distance;
                closestEnemy = enemy;
            }
        }

        if (closestEnemy != null && distanceToEnemy <= attackRange && !isAttacking && Time.time > lastAttackTime + attackCooldown)
        {
            isAttacking = true;
            lastAttackTime = Time.time;

            int attackType = Random.Range(1, 4);
            animator.SetInteger("AttackType", attackType);
            animator.SetTrigger("Attack");
        }
        else if (closestEnemy != null && distanceToEnemy <= attackRange)
        {
            isAttacking = false;
            animator.SetBool("Moving", false);
        }
        else if (closestEnemy == null || distanceToEnemy > attackRange)
        {
            isAttacking = false;
            animator.SetBool("Moving", true);
            transform.LookAt(new Vector3(0, transform.position.y, 0));
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
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

    public void MeleeAttack()
    {
        GameObject melee = Instantiate(meleePrefab, transform.position + transform.forward * 2.0f, Quaternion.identity);
        melee.GetComponent<Rigidbody>().velocity = transform.forward * 10.0f;
    }

    public void ThrowBomb()
    {
        GameObject bomb = Instantiate(bombPrefab, transform.position + transform.forward * 2.0f, Quaternion.identity);

        bomb.GetComponent<Rigidbody>().velocity = transform.forward * 10.0f;
    }




}
