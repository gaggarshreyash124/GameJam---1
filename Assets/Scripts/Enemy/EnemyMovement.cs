using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Enemy EnemyData;
    Rigidbody2D body;
    public GameObject Alert;
    private bool Alerted = false;

    int FacingDirection = 1;
    int Rotate = 180;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        EnemyData = GetComponent<EnemyHealth>().EnemyData;
        EnemyData.Initialize(GameData.Instance.TowerCleared);
    }

    private void Update()
    {
        if (PlayerIsDetected())
        {
            if (!Alerted)
            {
                body.velocity = Vector2.zero;
                Alerted = true;
                Instantiate(Alert, transform.position + new Vector3(1, 1.5f, 0), Quaternion.identity);
            }
        }
        else
        {
            body.velocity = new Vector2(EnemyData.MoveSpeed, body.velocity.y);
            Alerted = false;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Patrol"))
        {
            Flip();
        }
    }

    public void Flip()
    {
        FacingDirection *= -1;
        EnemyData.MoveSpeed *= -1;
        Rotate *= -1;
        transform.Rotate(0.0f, Rotate, 0.0f);
    }

    public bool PlayerIsDetected()
    {

        return Physics2D.Raycast(transform.position, Vector2.right * FacingDirection, EnemyData.minDetection, EnemyData.PlayerLayer);
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.right * FacingDirection * EnemyData.minDetection));

        
    }

    

}
