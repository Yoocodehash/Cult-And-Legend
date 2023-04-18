/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{


    // The amount of money to drop when the enemy dies
    public int moneyToDrop = 10;

    // The amount of ammo to drop when the enemy dies
    public int ammoToDrop = 5;

    // The money prefab that will be instantiated when the enemy dies
    public GameObject moneyPrefab;

    // The ammo prefab that will be instantiated when the enemy dies
    public GameObject ammoPrefab;

    // The sound that will be played when the enemy dies
    public AudioClip deathSound;

    // The speed at which the money and ammo will move towards the player
    public float pickupSpeed = 5.0f;

    // The distance at which the money and ammo can be picked up by the player
    public float pickupDistance = 1.0f;

    // The player object
    private GameObject player;

    // Whether the enemy is alive or not
    private bool isAlive = true;

    // Start is called before the first frame update
    void Start()
    {
        // Find the player object
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // If the enemy is dead and the money and ammo have not yet been picked up
        if (!isAlive && moneyPrefab != null && ammoPrefab != null)
        {
            // Move the money and ammo towards the player
            MoveTowardsPlayer(moneyPrefab);
            MoveTowardsPlayer(ammoPrefab);
        }
    }

    // This function is called when the enemy dies
    public void Die()
    {
        // Set isAlive to false
        isAlive = false;

        // Play the death sound
        AudioSource.PlayClipAtPoint(deathSound, transform.position);

        // Drop the money
        GameObject money = Instantiate(moneyPrefab, transform.position, Quaternion.identity);
        MoneyController moneyController = money.GetComponent<MoneyController>();
        moneyController.SetAmount(moneyToDrop);

        // Drop the ammo
        GameObject ammo = Instantiate(ammoPrefab, transform.position, Quaternion.identity);
        AmmoController ammoController = ammo.GetComponent<AmmoController>();
        ammoController.SetAmount(ammoToDrop);
    }

    // This function moves the specified object towards the player
    private void MoveTowardsPlayer(GameObject obj)
    {
        // Calculate the distance between the object and the player
        float distance = Vector3.Distance(obj.transform.position, player.transform.position);

        // If the object is within pickup distance
        if (distance <= pickupDistance)
        {
            // Move the object towards the player
            Vector3 direction = (player.transform.position - obj.transform.position).normalized;
            obj.transform.position += direction * pickupSpeed * Time.deltaTime;

            // If the object is close enough to the player, destroy it and add its value to the player's inventory
            if (distance <= 0.1f)
            {
                if (obj.GetComponent<MoneyController>() != null)
                {
                    player.GetComponent<Inventory>().AddMoney(obj.GetComponent<MoneyController>().GetAmount());
                }
                else if (obj.GetComponent<AmmoController>() != null)
                {
                    player.GetComponent<Inventory>().AddAmmo(obj.GetComponent<AmmoController>().GetAmount());
                }

                Destroy(obj);
            }
        }
    }


}

*/