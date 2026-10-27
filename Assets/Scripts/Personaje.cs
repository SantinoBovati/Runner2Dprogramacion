using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Personaje : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isGrounded = true;
    public float jumpforce = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.y, jumpforce);
            isGrounded = false;
        }
    } 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
} 

