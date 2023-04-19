/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponModifier : MonoBehaviour
{

    public int damage;
    public float fireRate;
    public int ammoCapacity;
    public float reloadTime;
    public List<Modifier> modifiers;

    public void Shoot()
    {
        // code to shoot the weapon
    }

    public void Reload()
    {
        // code to reload the weapon
    }

    public int CalculateDamage()
    {
        int totalDamage = damage;

        foreach (Modifier modifier in modifiers)
        {
            totalDamage += modifier.damageModifier;
        }

        return totalDamage;
    }
}

public class Modifier
{
    public string name;
    public int damageModifier;
    public float fireRateModifier;
    public int ammoCapacityModifier;
    public float reloadTimeModifier;
}

public class WeaponUI : MonoBehaviour
{
    public Weapon weapon;
    public Dropdown modifierDropdown;

    private List<Modifier> availableModifiers;

    private void Start()
    {
        // populate the dropdown with available modifiers
        availableModifiers = GetAvailableModifiers();
        List<string> modifierNames = new List<string>();
        foreach (Modifier modifier in availableModifiers)
        {
            modifierNames.Add(modifier.name);
        }
        modifierDropdown.AddOptions(modifierNames);
    }

    public void ApplyModifier()
    {
        // apply the selected modifier to the weapon
        int selectedModifierIndex = modifierDropdown.value;
        Modifier selectedModifier = availableModifiers[selectedModifierIndex];
        weapon.modifiers.Add(selectedModifier);
    }

    private List<Modifier> GetAvailableModifiers()
    {
        // get the list of available modifiers
        // in this example, we'll just return a hardcoded list of modifiers
        List<Modifier> availableModifiers = new List<Modifier>();
        availableModifiers.Add(new Modifier
        {
            name = "Fire",
            damageModifier = 10,
            fireRateModifier = 0,
            ammoCapacityModifier = 0,
            reloadTimeModifier = 0
        });
        availableModifiers.Add(new Modifier
        {
            name = "Ice",
            damageModifier = 5,
            fireRateModifier = 0,
            ammoCapacityModifier = 0,
            reloadTimeModifier = 0
        });
        availableModifiers.Add(new Modifier
        {
            name = "Poison",
            damageModifier = 7,
            fireRateModifier = 0,
            ammoCapacityModifier = 0,
            reloadTimeModifier = 0
        });
        return availableModifiers;
    }

}


*/