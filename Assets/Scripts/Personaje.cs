using UnityEngine;

public class Personaje : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool isGrounded = true;
    public float jumpforce = 5f;
    public float dropForce = 10f;

    // --- NUEVAS VARIABLES PARA EL DOBLE SALTO ---
    public int maxJumps = 2;       // Cantidad total de saltos permitidos (2 para doble salto)
    private int jumpsRemaining;    // Saltos que le quedan al jugador

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumpsRemaining = maxJumps; // Inicializamos con los saltos al máximo
    }

    void Update()
    {
        // Si se presiona Espacio Y le quedan saltos disponibles
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            // Aplicamos el salto en el eje Y manteniendo la velocidad X original
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);

            jumpsRemaining--;    // Restamos 1 salto disponible
            isGrounded = false;  // Ya no está tocando el suelo
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, -dropForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Al tocar el suelo (o cualquier objeto con colisión), reiniciamos los saltos
        isGrounded = true;
        jumpsRemaining = maxJumps; // Se resetea el contador a 2
    }
}

