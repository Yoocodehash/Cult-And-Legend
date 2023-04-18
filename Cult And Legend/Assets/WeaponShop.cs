using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class WeaponShop : MonoBehaviour
{


    public GameObject weaponPanel;
    public GameObject ammoPanel;
    public GameObject upgradesPanel;
    public GameObject partsPanel;

    public Text moneyText;

    public GameObject[] weapons;
    public int[] weaponPrices;

    public GameObject[] ammos;
    public int[] ammoPrices;

    public GameObject[] upgrades;
    public int[] upgradePrices;

    public GameObject[] parts;
    public int[] partPrices;

    private int currentMoney;

    void Start()
    {
        currentMoney = 1000;
        moneyText.text = "Money: " + currentMoney;
    }

    public void OpenWeaponPanel()
    {
        weaponPanel.SetActive(true);
        ammoPanel.SetActive(false);
        upgradesPanel.SetActive(false);
        partsPanel.SetActive(false);
    }

    public void OpenAmmoPanel()
    {
        weaponPanel.SetActive(false);
        ammoPanel.SetActive(true);
        upgradesPanel.SetActive(false);
        partsPanel.SetActive(false);
    }

    public void OpenUpgradesPanel()
    {
        weaponPanel.SetActive(false);
        ammoPanel.SetActive(false);
        upgradesPanel.SetActive(true);
        partsPanel.SetActive(false);
    }

    public void OpenPartsPanel()
    {
        weaponPanel.SetActive(false);
        ammoPanel.SetActive(false);
        upgradesPanel.SetActive(false);
        partsPanel.SetActive(true);
    }

    public void BuyWeapon(int index)
    {
        if (currentMoney >= weaponPrices[index])
        {
            currentMoney -= weaponPrices[index];
            moneyText.text = "Money: " + currentMoney;
            weapons[index].SetActive(true);
        }
    }

    public void BuyAmmo(int index)
    {
        if (currentMoney >= ammoPrices[index])
        {
            currentMoney -= ammoPrices[index];
            moneyText.text = "Money: " + currentMoney;
            // Add ammo to player inventory
        }
    }

    public void BuyUpgrade(int index)
    {
        if (currentMoney >= upgradePrices[index])
        {
            currentMoney -= upgradePrices[index];
            moneyText.text = "Money: " + currentMoney;
            // Upgrade player weapon
        }
    }

    public void BuyPart(int index)
    {
        if (currentMoney >= partPrices[index])
        {
            currentMoney -= partPrices[index];
            moneyText.text = "Money: " + currentMoney;
            // Add weapon part to player inventory
        }
    }


}
