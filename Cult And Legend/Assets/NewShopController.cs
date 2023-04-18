/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using static UnityEditor.Progress;

using UnityEngine.UI;


public class NewShopController : MonoBehaviour
{
    public List<Item> items = new List<Item>(); // list of available items
    public GameObject itemButtonPrefab; // prefab for item buttons
    public Transform itemButtonParent; // parent transform for item buttons
    public Text currencyText; // text component displaying the player's current currency
    public int currency = 0; // player's current currency

    private List<GameObject> instantiatedItemButtons = new List<GameObject>(); // list of instantiated item buttons

    private void Start()
    {
        // instantiate item buttons for each available item
        foreach (Item item in items)
        {
            GameObject itemButton = Instantiate(itemButtonPrefab, itemButtonParent);
            itemButton.GetComponent<ItemButton>().Setup(item, this);
            instantiatedItemButtons.Add(itemButton);
        }

        // update currency text
        UpdateCurrencyText();
    }

    public void PurchaseItem(Item item)
    {
        if (currency >= item.cost)
        {
            currency -= item.cost;
            UpdateCurrencyText();

            // TODO: implement logic for adding purchased item to player's inventory

            // disable purchase button for item
            foreach (GameObject itemButton in instantiatedItemButtons)
            {
                if (itemButton.GetComponent<ItemButton>().item == item)
                {
                    itemButton.GetComponent<ItemButton>().purchaseButton.interactable = false;
                    break;
                }
            }
        }
    }

    private void UpdateCurrencyText()
    {
        currencyText.text = "Currency: " + currency;
    }


}

*/