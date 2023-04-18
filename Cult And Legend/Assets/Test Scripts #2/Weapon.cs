/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{


    public int damage;
    public int maxAmmo;
    public int currentAmmo;
    public float reloadTime;
    public float fireRate;

    private bool isReloading = false;
    private bool isFiring = false;
    private float nextFireTime;

    public AudioSource audioSource;
    public AudioClip fireSound;
    public AudioClip reloadSound;

    public Animator animator;

    // Upgrade variables
    private int upgradeLevel = 0;
    private int[] damageUpgrades = { 10, 20, 30 };
    private int[] ammoUpgrades = { 10, 20, 30 };
    private float[] fireRateUpgrades = { 0.1f, 0.2f, 0.3f };
    private float[] reloadTimeUpgrades = { 0.5f, 0.3f, 0.1f };

    // Upgrade functions
    public void UpgradeDamage()
    {
        if (upgradeLevel < damageUpgrades.Length)
        {
            damage += damageUpgrades[upgradeLevel];
            upgradeLevel++;
        }
    }

    public void UpgradeAmmo()
    {
        if (upgradeLevel < ammoUpgrades.Length)
        {
            maxAmmo += ammoUpgrades[upgradeLevel];
            currentAmmo += ammoUpgrades[upgradeLevel];
            upgradeLevel++;
        }
    }

    public void UpgradeFireRate()
    {
        if (upgradeLevel < fireRateUpgrades.Length)
        {
            fireRate -= fireRateUpgrades[upgradeLevel];
            upgradeLevel++;
        }
    }

    public void UpgradeReloadTime()
    {
        if (upgradeLevel < reloadTimeUpgrades.Length)
        {
            reloadTime -= reloadTimeUpgrades[upgradeLevel];
            upgradeLevel++;
        }
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time >= nextFireTime && !isReloading && currentAmmo > 0)
        {
            nextFireTime = Time.time + 1f / fireRate;
            isFiring = true;
            currentAmmo--;

            animator.SetTrigger("Fire");
            audioSource.PlayOneShot(fireSound);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                Enemy enemy = hit.transform.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.R) && !isReloading && currentAmmo < maxAmmo)
        {
            isReloading = true;
            animator.SetTrigger("Reload");
            audioSource.PlayOneShot(reloadSound);
            StartCoroutine(Reload());
        }

        if (isFiring)
        {
            isFiring = false;
        }
    }

    IEnumerator Reload()
    {
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloading = false;
    }


}

*/