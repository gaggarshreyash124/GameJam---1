using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemyStats
{
    public static EnemyStats Instance;
    public float MaxHealth;
    public float CurrentHealth;

    private void Awake()
    {
        Instance = this;
        MaxHealth = Mathf.RoundToInt(100 * (GameData.Instance.TowerCleared * 0.5f + 1));
        CurrentHealth = MaxHealth;
    }
}
    