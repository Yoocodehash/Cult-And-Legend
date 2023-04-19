using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class EnemyHealthBar : MonoBehaviour
{


    public Slider healthBarPrefab;
    public Transform canvas;

    private Slider healthBar;

    private void Start()
    {
        // instantiate the health bar prefab and parent it to the canvas
        healthBar = Instantiate(healthBarPrefab, canvas);
        healthBar.gameObject.SetActive(false);
    }

    public void ShowHealthBar()
    {
        // show the health bar
        healthBar.gameObject.SetActive(true);
    }

    public void HideHealthBar()
    {
        // hide the health bar
        healthBar.gameObject.SetActive(false);
    }

    public void UpdateHealthBar(float currentHealth, float maxHealth)
    {
        // update the health bar value and fill amount
        healthBar.value = currentHealth;
        healthBar.maxValue = maxHealth;
        healthBar.fillRect.GetComponent<Image>().color = Color.Lerp(Color.red, Color.green, currentHealth / maxHealth);
    }


}
