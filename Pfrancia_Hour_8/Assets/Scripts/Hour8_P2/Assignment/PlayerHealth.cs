using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3992;
    public int playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = maxHealth;
    }

    // Update is called once per frame
    void PlayerTakeDamage(int damage)
    {
        playerHealth = playerHealth - damage;
    }
}
