using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public GameObject HealthBarUi;
    public GameObject gameOverScreen;
    public GameObject LiveUi;
    public GameObject EscapedScreen;

    public HealthBar healthBar;
  
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0 && !EscapedScreen.activeSelf)
        {
            ClueSystem.numClueCollected = 0;
            HealthBarUi.SetActive(false);
            LiveUi.SetActive(false);
            gameOverScreen.SetActive(true);
        }
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
