    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemies/New Enemy")]
public class Enemy : ScriptableObject
{
    //stats
    
    [Header("Stats")]
    public float MaxHealth;
    public float CurrentHealth;
    public float Defence;
    public float AttackPower;
    public float MoveSpeed;

    //Detection
    public float minDetection;
    public float AttackRange;
    public float AttackHeight;
    public LayerMask PlayerLayer;

    public void Initialize(float towerCleared)
    {
        MaxHealth = Mathf.RoundToInt(MaxHealth * (towerCleared * 0.5f + 1));
        CurrentHealth = MaxHealth;
        Defence = Mathf.RoundToInt(Defence * (towerCleared * 0.5f + 1));
        AttackPower = Mathf.RoundToInt(AttackPower * (towerCleared * 0.5f + 1));
    }

}
