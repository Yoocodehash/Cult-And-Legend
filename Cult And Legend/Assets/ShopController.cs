using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ShopController : MonoBehaviour
{


    public Character[] characters; // Array of available characters
    public GameObject characterButtonPrefab; // Prefab for character buttons
    public Transform characterButtonParent; // Parent transform for character buttons
    public Text coinsText; // Text to display the player's coins

    private int coins; // Player's current number of coins

    void Start()
    {
        // Get the player's current number of coins from the save file
        coins = PlayerPrefs.GetInt("Coins", 0);

        // Display the player's current number of coins
        coinsText.text = "Coins: " + coins.ToString();

        // Create a button for each available character
        foreach (Character character in characters)
        {
            GameObject button = Instantiate(characterButtonPrefab, characterButtonParent);
            button.GetComponent<CharacterButton>().Setup(character, this);
        }
    }

    public void PurchaseCharacter(Character character)
    {
        // Check if the player has enough coins to purchase the character
        if (coins >= character.cost)
        {
            // Deduct the cost from the player's coins
            coins -= character.cost;

            // Save the new number of coins to the save file
            PlayerPrefs.SetInt("Coins", coins);

            // Display the new number of coins
            coinsText.text = "Coins: " + coins.ToString();

            // Unlock the character for the player
            character.isUnlocked = true;

            // Disable the purchase button for the character
            characterButtonParent.Find(character.name).GetComponent<CharacterButton>().DisablePurchaseButton();
        }
    }
}

[System.Serializable]
public class Character
{
    public string name; // Name of the character
    public int cost; // Cost of the character
    public Sprite icon; // Icon for the character
    public bool isUnlocked; // Flag indicating whether the character is unlocked
}

public class CharacterButton : MonoBehaviour
{
    public Image iconImage; // Image component for the button's icon
    public Text nameLabel; // Text component for the button's name
    public Text costLabel; // Text component for the button's cost
    public GameObject purchaseButton; // Purchase button for the character

    private Character character; // Character represented by the button
    private ShopController shopController; // Shop controller for the button

    public void Setup(Character character, ShopController shopController)
    {
        this.character = character;
        this.shopController = shopController;

        // Set the icon, name, and cost for the button
        iconImage.sprite = character.icon;
        nameLabel.text = character.name;
        costLabel.text = character.cost.ToString();

        // Disable the purchase button if the character is already unlocked
        if (character.isUnlocked)
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
        shopController.PurchaseCharacter(character);
    }


}
