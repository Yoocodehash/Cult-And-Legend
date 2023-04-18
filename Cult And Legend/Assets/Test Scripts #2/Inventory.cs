using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Inventory : MonoBehaviour
{


    // The starting amount of money and ammo
    public int startingMoney = 0;
    public int startingAmmo = 0;

    // The current amount of money and ammo
    private int currentMoney;
    private int currentAmmo;

    // The UI text objects that display the current amount of money and ammo
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI ammoText;

    // Start is called before the first frame update
    void Start()
    {
        // Set the current money and ammo to the starting values
        currentMoney = startingMoney;
        currentAmmo = startingAmmo;

        // Update the UI text objects to display the current amount of money and ammo
        UpdateUI();
    }

    // Add money to the inventory
    public void AddMoney(int amount)
    {
        currentMoney += amount;
        UpdateUI();
    }

    // Subtract money from the inventory
    public void SubtractMoney(int amount)
    {
        currentMoney -= amount;
        UpdateUI();
    }

    // Add ammo to the inventory
    public void AddAmmo(int amount)
    {
        currentAmmo += amount;
        UpdateUI();
    }

    // Subtract ammo from the inventory
    public void SubtractAmmo(int amount)
    {
        currentAmmo -= amount;
        UpdateUI();
    }

    // Update the UI text objects to display the current amount of money and ammo
    private void UpdateUI()
    {
        moneyText.text = "Money: " + currentMoney;
        ammoText.text = "Ammo: " + currentAmmo;
    }


}
