
/*
 * Author: Leo Shao Wei Joel
 * Date: 30/06/2024
 * Description: First Aid Kit code  
 */using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstaidkit : MonoBehaviour
{
    // Start is called before the first frame update
    public int healAmount = 1; // Amount of health to restore

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            KillPlayer playerHealth = other.GetComponent<KillPlayer>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healAmount); // Restore player health
                Destroy(gameObject); // Destroy the first aid kit object
            }
        }
    }
}
