using UnityEngine;

public class LoopFondo : MonoBehaviour
{
    public Transform otroFondo;
    public float anchoFondo = 20f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("StreetTrigger") || collision.name == "StreetTrigger2")
        {
            float nuevaPosX = otroFondo.position.x + anchoFondo;
            transform.position = new Vector3(nuevaPosX, transform.position.y, transform.position.z);
        }
    }
}
