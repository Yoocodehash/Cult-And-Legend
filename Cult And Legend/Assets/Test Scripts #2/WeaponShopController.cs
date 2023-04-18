/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponShopController : MonoBehaviour
{

    public Weapon[] weapons; // Array of available weapons
    public GameObject weaponButtonPrefab; // Prefab for weapon buttons
    public Transform weaponButtonParent; // Parent transform for weapon buttons
    public Text coinsText; // Text to display the player's coins

    private int coins; // Player's current number of coins

    void Start()
    {
        // Get the player's current number of coins from the save file
        coins = PlayerPrefs.GetInt("Coins", 0);

        // Display the player's current number of coins
        coinsText.text = "Coins: " + coins.ToString();

        // Create a button for each available weapon
        foreach (Weapon weapon in weapons)
        {
            GameObject button = Instantiate(weaponButtonPrefab, weaponButtonParent);
            button.GetComponent<WeaponButton>().Setup(weapon, this);
        }
    }

    public void PurchaseWeapon(Weapon weapon)
    {
        // Check if the player has enough coins to purchase the weapon
        if (coins >= weapon.cost)
        {
            // Deduct the cost from the player's coins
            coins -= weapon.cost;

            // Save the new number of coins to the save file
            PlayerPrefs.SetInt("Coins", coins);

            // Display the new number of coins
            coinsText.text = "Coins: " + coins.ToString();

            // Add the weapon to the player's inventory
            Inventory.instance.Add(weapon);

            // Disable the purchase button for the weapon
            weaponButtonParent.Find(weapon.name).GetComponent<WeaponButton>().DisablePurchaseButton();
        }
    }
}

[System.Serializable]
public class Weapon
{
    public string name; // Name of the weapon
    public int cost; // Cost of the weapon
    public Sprite icon; // Icon for the weapon
    public GameObject prefab; // Prefab for the weapon
    public int damage; // Damage dealt by the weapon
    public float fireRate; // Rate of fire for the weapon
    public float range; // Range of the weapon
}

public class WeaponButton : MonoBehaviour
{
    public Image iconImage; // Image component for the button's icon
    public Text nameLabel; // Text component for the button's name
    public Text costLabel; // Text component for the button's cost
    public GameObject purchaseButton; // Purchase button for the weapon

    private Weapon weapon; // Weapon represented by the button
    private ShopController shopController; // Shop controller for the button

    public void Setup(Weapon weapon, ShopController shopController)
    {
        this.weapon = weapon;
        this.shopController = shopController;

        // Set the icon, name, and cost for the button
        iconImage.sprite = weapon.icon;
        nameLabel.text = weapon.name;
        costLabel.text = weapon.cost.ToString();

        // Disable the purchase button if the weapon is already in the player's inventory
        if (Inventory.instance.Contains(weapon))
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
        shopController.PurchaseWeapon(weapon);
    }
}

public class Inventory : MonoBehaviour
{
    public static Inventory instance;

    public List<Weapon> weapons = new List<Weapon>();

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy();

        }

        public void Add(Weapon weapon)
        {
            weapons.Add(weapon);
        }

        public bool Contains(Weapon weapon)
        {
            return weapons.Contains(weapon);
        }



    }
}

*/