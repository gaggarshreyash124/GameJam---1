using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    [SerializeField] float DissapearTime;
    public Rigidbody2D rb;
    public TextMeshPro Text;

    public void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        Text = GetComponent<TextMeshPro>();
    }

    public void ChangeText(float damage)
    {
        Text.text = damage.ToString();
    }

    public void Update()
    {
        rb.velocity = new Vector2(0, 2);
        DissapearTime -= Time.deltaTime;
        if (DissapearTime <= 0)
        {
            Destroy();
        }
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
