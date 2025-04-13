using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        double health = 100;

        health = TakeDamage(health, 20);
        Debug.Log(health);

        health = TakeDamage(health, 20);
        Debug.Log(health);

        health = TakeDamage(health, 30, 0.5);
        Debug.Log(health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    double TakeDamage(double health, double damage, double damageModifier)
    {
        return health - (damage * damageModifier);
    }

    double TakeDamage(double health, double damage)
    {
        return health - damage;
    }
}
