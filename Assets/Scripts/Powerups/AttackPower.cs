using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackPower
{
    public static AttackPower instance;
    public int Stack;
    public int Increase;

    public void Awake()
    {
        instance = this;
    }

    public void AttackPowerup()
    {
        GameData.Instance.PlayerStats.AttackPower += Increase;
        Stack++;
        
    }
}
