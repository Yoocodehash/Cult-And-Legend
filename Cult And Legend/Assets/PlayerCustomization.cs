using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerCustomization : MonoBehaviour
{


    public List<CustomizationOption> availableOptions;

    public GameObject characterModel;

    public Dropdown hatDropdown;
    public Dropdown glassesDropdown;
    public Dropdown shirtDropdown;
    public Dropdown pantsDropdown;

    private Dictionary<CustomizationType, Dropdown> dropdowns;

    private void Start()
    {
        // create a dictionary to store the dropdowns
        dropdowns = new Dictionary<CustomizationType, Dropdown>
        {
            { CustomizationType.Hat, hatDropdown },
            { CustomizationType.Glasses, glassesDropdown },
            { CustomizationType.Shirt, shirtDropdown },
            { CustomizationType.Pants, pantsDropdown }
        };

        // populate the dropdowns with available options
        foreach (CustomizationOption option in availableOptions)
        {
            if (dropdowns.TryGetValue(option.type, out Dropdown dropdown))
            {
                dropdown.options.Add(new Dropdown.OptionData(option.name));
            }
        }

        // set the initial customization options
        SetCustomizationOptions(new List<CustomizationOption>
        {
            availableOptions[0],
            availableOptions[1],
            availableOptions[2],
            availableOptions[3]
        });
    }

    public void SetCustomizationOptions(List<CustomizationOption> options)
    {
        // apply the selected customization options
        foreach (CustomizationOption option in options)
        {
            if (dropdowns.TryGetValue(option.type, out Dropdown dropdown))
            {
                dropdown.value = option.index;
            }
        }

        // update the character model
        UpdateCharacterModel(options);
    }

    private void UpdateCharacterModel(List<CustomizationOption> options)
    {
        // update the character model based on the selected customization options
        // in this example, we'll just change the color of the character's clothing based on the selected options
        Color hatColor = Color.white;
        Color glassesColor = Color.white;
        Color shirtColor = Color.white;
        Color pantsColor = Color.white;

        foreach (CustomizationOption option in options)
        {
            switch (option.type)
            {
                case CustomizationType.Hat:
                    hatColor = option.color;
                    break;
                case CustomizationType.Glasses:
                    glassesColor = option.color;
                    break;
                case CustomizationType.Shirt:
                    shirtColor = option.color;
                    break;
                case CustomizationType.Pants:
                    pantsColor = option.color;
                    break;
            }
        }

        Renderer[] renderers = characterModel.GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            if (renderer.material.name.Contains("hat"))
            {
                renderer.material.color = hatColor;
            }
            else if (renderer.material.name.Contains("glasses"))
            {
                renderer.material.color = glassesColor;
            }
            else if (renderer.material.name.Contains("shirt"))
            {
                renderer.material.color = shirtColor;
            }
            else if (renderer.material.name.Contains("pants"))
            {
                renderer.material.color = pantsColor;
            }
        }
    }
}

public enum CustomizationType
{
    Hat,
    Glasses,
    Shirt,
    Pants
}

[System.Serializable]
public class CustomizationOption
{
    public string name;
    public CustomizationType type;
    public int index;
    public Color color;
}





[System.Serializable]
public class WeaponElement
{
    public string name;
    public Color color;
}

[System.Serializable]
public class Weapon
{
    public string name;
    public int damage;
    public float fireRate;
    public List<WeaponElement> elements;
}

public class WeaponCustomization : MonoBehaviour
{
    public List<Weapon> availableWeapons;

    public GameObject weaponModel;
    public Dropdown weaponDropdown;
    public Text damageText;
    public Text fireRateText;
    public Image[] elementImages;

    private Weapon currentWeapon;

    private void Start()
    {
        // populate the weapon dropdown with available weapons
        foreach (Weapon weapon in availableWeapons)
        {
            weaponDropdown.options.Add(new Dropdown.OptionData(weapon.name));
        }

        // set the initial weapon
        SetWeapon(availableWeapons[0]);
    }

    public void SetWeapon(Weapon weapon)
    {
        // apply the selected weapon
        currentWeapon = weapon;
        weaponDropdown.value = availableWeapons.IndexOf(weapon);

        // update the weapon model
        UpdateWeaponModel();

        // update the damage and fire rate texts
        damageText.text = "Damage: " + currentWeapon.damage.ToString();
        fireRateText.text = "Fire Rate: " + currentWeapon.fireRate.ToString();

        // update the element images
        for (int i = 0; i < elementImages.Length; i++)
        {
            if (i < currentWeapon.elements.Count)
            {
                elementImages[i].color = currentWeapon.elements[i].color;
            }
            else
            {
                elementImages[i].color = Color.clear;
            }
        }
    }

    private void UpdateWeaponModel()
    {
        // update the weapon model based on the selected weapon
        // in this example, we'll just change the color of the weapon based on the selected elements
        Color elementColor = Color.white;
        foreach (WeaponElement element in currentWeapon.elements)
        {
            elementColor += element.color;
        }
        elementColor /= currentWeapon.elements.Count;

        Renderer[] renderers = weaponModel.GetComponentsInChildren<Renderer>();
        foreach (Renderer renderer in renderers)
        {
            if (renderer.material.name.Contains("element"))
            {
                renderer.material.color = elementColor;
            }
        }
    }



}
