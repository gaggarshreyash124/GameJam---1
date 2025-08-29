using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AttackPower attackPower;
    public SugarRush sugarRush;

    private Rigidbody2D rb;
    public Transform groundCheck;

    public float SkillTime;
    public bool Active;

    private bool GroundCheck()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, GameData.Instance.PlayerStats.GroundLayer);
    }

    void Awake()
    {
        attackPower = new AttackPower();
        sugarRush = new SugarRush();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * GameData.Instance.PlayerStats.MoveSpeed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck())
        {
            rb.AddForce(new Vector2(0f, GameData.Instance.PlayerStats.JumpForce), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.Z) && !Active)
        {
            SkillTime = Time.time;
            sugarRush.ActivePowerUp();
            Active = true;
        }
        if (Time.time >= SkillTime + GameData.Instance.PlayerStats.SugarRushDuration && Active)
        {
            sugarRush.RemovePowerUp();
            Active = false;
            return;
        }
            
        
    }
    

}
