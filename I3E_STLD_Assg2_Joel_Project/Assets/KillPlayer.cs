using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int respawnSceneIndex;  // Scene index to respawn
    public int gameOverSceneIndex; // Scene index for game over
    public GameObject heart0, heart1, heart2; // Heart GameObjects
    public static int health = 3; // Static health variable initialized to 3

    void Start()
    {
        UpdateHearts();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
        UpdateHearts();
        CheckHealth();
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > 3) health = 3;
        UpdateHearts();
    }

    void UpdateHearts()
    {
        heart0.SetActive(health >= 1);
        heart1.SetActive(health >= 2);
        heart2.SetActive(health >= 3);
    }

    void CheckHealth()
    {
        if (health <= 0)
        {
            // You can decide if you want to go to a respawn scene or a game over scene
            if (respawnSceneIndex >= 0)
            {
                SceneManager.LoadScene(respawnSceneIndex); // Load the respawn scene
                health = 3; // Reset health
            }
            else
            {
                SceneManager.LoadScene(gameOverSceneIndex); // Load the game over scene
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TakeDamage(1); // Adjust the health decrement as necessary
        }

    }
}