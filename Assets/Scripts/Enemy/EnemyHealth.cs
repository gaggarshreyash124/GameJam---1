using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public Enemy EnemyData;
    public Transform DamagePopupTransform;
    public DamagePopup DamagePopup;

    
     void Update()
    {
        if (Input.GetKeyDown("k"))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(float damage)
    {
        EnemyData.CurrentHealth -= damage;
        DamagePopup.ChangeText(damage);
        Instantiate(DamagePopupTransform, transform.position, Quaternion.identity);

        if (EnemyData.CurrentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        EnemyData.CurrentHealth += amount;
        if (EnemyData.CurrentHealth > EnemyData.MaxHealth)
        {
            EnemyData.CurrentHealth = EnemyData.MaxHealth;
        }
    }

    private void Die()
    {
        Destroy(gameObject, 2f);
    }
}