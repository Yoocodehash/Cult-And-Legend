/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AbilityShopController : MonoBehaviour
{


    public Ability[] abilities; // Array of available abilities
    public GameObject abilityButtonPrefab; // Prefab for ability buttons
    public Transform abilityButtonParent; // Parent transform for ability buttons
    public Text coinsText; // Text to display the player's coins

    private int coins; // Player's current number of coins

    void Start()
    {
        // Get the player's current number of coins from the save file
        coins = PlayerPrefs.GetInt("Coins", 0);

        // Display the player's current number of coins
        coinsText.text = "Coins: " + coins.ToString();

        // Create a button for each available ability
        foreach (Ability ability in abilities)
        {
            GameObject button = Instantiate(abilityButtonPrefab, abilityButtonParent);
            button.GetComponent<AbilityButton>().Setup(ability, this);
        }
    }

    public void PurchaseAbility(Ability ability)
    {
        // Check if the player has enough coins to purchase the ability
        if (coins >= ability.cost)
        {
            // Deduct the cost from the player's coins
            coins -= ability.cost;

            // Save the new number of coins to the save file
            PlayerPrefs.SetInt("Coins", coins);

            // Display the new number of coins
            coinsText.text = "Coins: " + coins.ToString();

            // Unlock the ability for the player
            ability.isUnlocked = true;

            // Disable the purchase button for the ability
            abilityButtonParent.Find(ability.name).GetComponent<AbilityButton>().DisablePurchaseButton();
        }
    }
}

[System.Serializable]
public class Ability
{
    public string name; // Name of the ability
    public int cost; // Cost of the ability
    public Sprite icon; // Icon for the ability
    public bool isUnlocked; // Flag indicating whether the ability is unlocked
}

public class AbilityButton : MonoBehaviour
{
    public Image iconImage; // Image component for the button's icon
    public Text nameLabel; // Text component for the button's name
    public Text costLabel; // Text component for the button's cost
    public GameObject purchaseButton; // Purchase button for the ability

    private Ability ability; // Ability represented by the button
    private ShopController shopController; // Shop controller for the button

    public void Setup(Ability ability, ShopController shopController)
    {
        this.ability = ability;
        this.shopController = shopController;

        // Set the icon, name, and cost for the button
        iconImage.sprite = ability.icon;
        nameLabel.text = ability.name;
        costLabel.text = ability.cost.ToString();

        // Disable the purchase button if the ability is already unlocked
        if (ability.isUnlocked)
        {
            DisablePurchaseButton();
        }
    }

    public void DisablePurchaseButton()
    {
        purchaseButton.SetActive(false);
    }

    public void OnPurchaseButtonClick()
    {
        shopController.PurchaseAbility(ability);
    }


}

*/