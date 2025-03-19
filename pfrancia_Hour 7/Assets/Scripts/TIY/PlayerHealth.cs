using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int health = 100;

        if (health == 0) // == equal, != not equal
        {
            Debug.Log("player has been unallived!");
        }
        else if (health < 30)
        {
            Debug.Log("Danger Low Health!");
        }
        else if (health == 100)
        {
            Debug.Log("player is chilling!");
        }
        else
        {
            Debug.Log("player is alive!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
