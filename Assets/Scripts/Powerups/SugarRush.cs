using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SugarRush
{
    public static SugarRush instance;
    
    //Increase Attack and Defence Speed Decrease
    public int AttackIncrease = 15;
    public int DefenceIncrease = 5;
    public int SpeedDecrease = 2;

    public float StartTime;
    
    public void Awake()
    {
        instance = this;
    
    }

    public void ActivePowerUp()
    {
        
        GameData.Instance.PlayerStats.AttackPower += AttackIncrease;
        GameData.Instance.PlayerStats.Defence += DefenceIncrease;
        GameData.Instance.PlayerStats.MoveSpeed -= SpeedDecrease;

        Debug.Log("Sugar Rush Active");
    }

    public void RemovePowerUp()
    {
        GameData.Instance.PlayerStats.AttackPower -= AttackIncrease;
        GameData.Instance.PlayerStats.Defence -= DefenceIncrease;
        GameData.Instance.PlayerStats.MoveSpeed += SpeedDecrease;

        Debug.Log("Sugar Rush Ended");
    }


}
