using UnityEngine;

public class LoopSuelo : MonoBehaviour
{
    public Transform otroSuelo;
    public float anchoSuelo = 20f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("StreetTrigger") || collision.name == "StreetTrigger")
        {
            float nuevaPosX = otroSuelo.position.x + anchoSuelo;
            transform.position = new Vector3(nuevaPosX, transform.position.y, transform.position.z);
        }
    }
}
