using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 100; // Set the player's max health in the Inspector
    private int healthRegen = 25;

    void Start()
    {
        currentHealth = maxHealth;
    }

    // Method to change health (healing or damage)
    public void ChangeHealth(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth); // Keep within bounds
    }

    // Method to consume a potion
    public void UseHealthPotion(int healAmount)
    {
        ChangeHealth(healAmount);
    }

    public void RegenHealth()
    {
        if (currentHealth < maxHealth)
        {
            ChangeHealth(healthRegen);
        }
    }
}
