using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NinjaDelivery
{
  public class Player : MonoBehaviour
  {
    [SerializeField] private LevelLoader levelLoader;

    [Header("Health")]
    [SerializeField] private HealthBar healthBar;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;

    void Start()
    {
      currentHealth = maxHealth;
      healthBar.SetMaxHealth(maxHealth);
      Time.timeScale = 1;
    }

    void Update()
    {
      if (currentHealth <= 0) Die();

      if (Input.GetKeyDown(KeyCode.R)) Application.LoadLevel(Application.loadedLevel);
    }

    public void TakeDamage(int damage)
    {
      currentHealth -= damage;
      healthBar.SetHealth(currentHealth);
    }

    public void Die()
    {
      Destroy(gameObject);
      levelLoader.LoadLevel("GameOver");
      Time.timeScale = 0;
    }
  }
}
