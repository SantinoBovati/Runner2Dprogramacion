using UnityEngine;
using UnityEngine.SceneManagement;

public class Personaje : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isGrounded = true;
    public float jumpforce = 5f;
    public float dropForce = 10f;

    public int maxJumps = 2;
    private int jumpsRemaining;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsRemaining = maxJumps;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);

            jumpsRemaining--;
            isGrounded = false;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -dropForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        jumpsRemaining = maxJumps;

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            float puntuacionFinal = Time.timeSinceLevelLoad * 10f;

            PlayerPrefs.SetFloat("PuntuacionFinal", puntuacionFinal);
            PlayerPrefs.Save();

            SceneManager.LoadScene("GameOver");
        }
    }


}

