/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StunAbility : MonoBehaviour
{


    public float stunDuration = 2f;
    public float stunRadius = 5f;
    public LayerMask enemyLayerMask;

    private void Update()
    {
        if (Input.GetButtonDown("Stun"))
        {
            StunEnemies();
        }
    }

    private void StunEnemies()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, stunRadius, enemyLayerMask);

        foreach (Collider hitCollider in hitColliders)
        {
            EnemyController enemyController = hitCollider.GetComponent<EnemyController>();
            if (enemyController != null)
            {
                enemyController.StartCoroutine(StunCoroutine(enemyController));
            }
        }
    }

    private IEnumerator StunCoroutine(EnemyController enemyController)
    {
        enemyController.DisableMovement();
        enemyController.DisableAttack();

        yield return new WaitForSeconds(stunDuration);

        enemyController.EnableMovement();
        enemyController.EnableAttack();
    }


}

*/