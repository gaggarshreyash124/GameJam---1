using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance;
    public EnemyStats EnemyStats;
    public PlayerStats PlayerStats;

    public int TowerCleared = 0;
    private float CurrentDifficulty = 1;
    private float DifficultyIncreaseRate = 1.2f;



    public void Awake()
    {
        EnemyStats = new EnemyStats();
        PlayerStats = new PlayerStats();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);  // Keeps across scenes
        }
        else
        {
            Destroy(gameObject); // Prevent duplicates
        }
        
    }
    public void IncreaseDifficulty()
    {
        CurrentDifficulty *= DifficultyIncreaseRate;
    }

    public void ResetDifficulty(int Deaths)
    {
        CurrentDifficulty = 1 + (Deaths * 0.1f);
    }

}
