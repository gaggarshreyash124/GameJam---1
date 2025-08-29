using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "Player/Data")]
public class PlayerData : ScriptableObject
{
    //stats

    [Header("Stats")]
    public float MaxHealth;
    public float CurrentHealth;
    public float Defence;
    public float AttackPower;
    public float MoveSpeed;
    public float JumpForce;

    //Detection
    public float minDetection;
    public LayerMask GroundLayer;

    //Information
    public int Deaths;
    public float SugarRushDuration;

    public void Initialize(float towerCleared)
    {
        MaxHealth = Mathf.RoundToInt(MaxHealth * (towerCleared * 0.5f + 1));
        CurrentHealth = MaxHealth;
        Defence = Mathf.RoundToInt(Defence * (towerCleared * 0.5f + 1));
        AttackPower = Mathf.RoundToInt(AttackPower * (towerCleared * 0.5f + 1));
    }
}
