using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public LayerMask groundLayer;
    public Transform groundCheck;


    private bool GroundCheck()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundLayer);
    }
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        
        if (Input.GetKeyDown(KeyCode.Space) && GroundCheck())
        {
            rb.AddForce(new Vector2(0f, 7f), ForceMode2D.Impulse);
        }
    }
}
