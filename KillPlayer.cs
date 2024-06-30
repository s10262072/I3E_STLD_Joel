using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour
{
    public int Respawn;  // Scene index to respawn
    public GameObject heart, heart1, heart2; // Heart GameObjects
    public static int health; // Static health variable

    void Start()
    {
        health = 3;
        UpdateHearts();
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0) health = 0;
        UpdateHearts();
    }

    public void Heal(int amount)
    {
        health += amount;
        if (health > 3) health = 3;
        UpdateHearts();
    }

    void UpdateHearts()
    {
        heart.SetActive(health >= 1);
        heart1.SetActive(health >= 2);
        heart2.SetActive(health >= 3);
    }

    void Update()
    {
        // Update logic if needed
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            health = 2;
            UpdateHearts();
            SceneManager.LoadScene(3);
        }
    }
}