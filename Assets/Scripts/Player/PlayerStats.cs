using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerStats
{
    public static PlayerStats Instance;
    public float MaxHealth;
    public float CurrentHealth;
    public int AttackPower;
    public int Deaths;

    private void Awake()
    {
        Instance = this;
        MaxHealth = 100;
        CurrentHealth = MaxHealth;
    }
}
