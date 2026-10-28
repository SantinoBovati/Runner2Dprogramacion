using UnityEngine;

public class MovimientoObstaculo : MonoBehaviour
{
    public float velocidad = 5f;

    void Update()
    {
        transform.position -= new Vector3(velocidad * Time.deltaTime, 0, 0);
    }

}