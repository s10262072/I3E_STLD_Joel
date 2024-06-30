using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public Image[] healthIcons;
    public Sprite fullHealthIcon;
    public Sprite emptyHealthIcon;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateHealthUI();
    }

    public void RegainHealth(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        for (int i = 0; i < healthIcons.Length; i++)
        {
            if (i < currentHealth)
            {
                healthIcons[i].sprite = fullHealthIcon;
            }
            else
            {
                healthIcons[i].sprite = emptyHealthIcon;
            }
        }
    }
}