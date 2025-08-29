using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    
    public Transform DamagePopupTransform;
    public DamagePopup DamagePopup;

   

    public void TakeDamage(float damage)
    {
        GameData.Instance.EnemyStats.CurrentHealth -= damage;
        DamagePopup.ChangeText(damage);
        Instantiate(DamagePopupTransform, transform.position, Quaternion.identity);

        if (GameData.Instance.EnemyStats.CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        GameData.Instance.EnemyStats.CurrentHealth += amount;
        if (GameData.Instance.EnemyStats.CurrentHealth > GameData.Instance.EnemyStats.MaxHealth)
        {
            GameData.Instance.EnemyStats.CurrentHealth = GameData.Instance.EnemyStats.MaxHealth;
        }
    }

    private void Die()
    {
        // Implementation for enemy death
    }
}