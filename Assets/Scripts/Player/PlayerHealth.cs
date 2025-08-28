using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    
    public bool isDead = false;

    public void TakeDamage(float damage)
    {
        GameData.Instance.PlayerStats.CurrentHealth -= damage;

        if (GameData.Instance.PlayerStats.CurrentHealth <= 0 && !isDead)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        GameData.Instance.PlayerStats.CurrentHealth += amount;
        if (GameData.Instance.PlayerStats.CurrentHealth > GameData.Instance.PlayerStats.MaxHealth)
        {
            GameData.Instance.PlayerStats.CurrentHealth = GameData.Instance.PlayerStats.MaxHealth;
        }
    }

    private void Die()
    {
       
    }
}
