using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody2D body;
    public float moveSpeed = 2f;
    public GameObject Alert;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    private void Update()
    {
        body.velocity = new Vector2(moveSpeed, body.velocity.y);
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
        Vector3 currentScale = transform.localScale;
        currentScale.x *= -1;
        transform.localScale = currentScale;
        moveSpeed *= -1;
    }

}
