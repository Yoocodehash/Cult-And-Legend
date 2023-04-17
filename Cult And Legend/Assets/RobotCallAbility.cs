/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotCallAbility : MonoBehaviour
{

    public GameObject robotPrefab;

    private bool isRobotActive = false;
    private GameObject robotInstance;

    private void Update()
    {
        if (!isRobotActive && Input.GetButtonDown("RobotCall"))
        {
            CallRobot();
        }
    }

    private void CallRobot()
    {
        isRobotActive = true;

        robotInstance = Instantiate(robotPrefab, transform.position, transform.rotation);
        RobotController robotController = robotInstance.GetComponent<RobotController>();
        robotController.target = FindClosestEnemy();
        robotController.OnRobotDestroyed += OnRobotDestroyed;
    }

    private void OnRobotDestroyed()
    {
        isRobotActive = false;
    }

    private Enemy FindClosestEnemy()
    {
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        Enemy closestEnemy = null;
        float closestDistance = Mathf.Infinity;

        foreach (Enemy enemy in enemies)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);

            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestEnemy = enemy;
            }
        }

        return closestEnemy;
    }


}

*/