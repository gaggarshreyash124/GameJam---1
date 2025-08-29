using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public Enemy EnemyData;
    public float AttackCooldown = 1f;
    

    void Awake()
    {
        EnemyData = GetComponent<EnemyHealth>().EnemyData;
        
    }

    public bool CanAttack()
    {
        return Physics2D.BoxCast(transform.position, new Vector2(1, 1), 0, Vector2.zero, 0, EnemyData.PlayerLayer);
    }
}
