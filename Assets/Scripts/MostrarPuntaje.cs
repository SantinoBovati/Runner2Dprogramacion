using UnityEngine;
using TMPro;

public class MostrarPuntaje : MonoBehaviour
{
    public TextMeshProUGUI textoPuntuacion;

    void Start()
    {
        float puntajeObtenido = PlayerPrefs.GetFloat("PuntuacionFinal", 0f);

        int puntajeRedondeado = Mathf.FloorToInt(puntajeObtenido);

        if (textoPuntuacion != null)
        {
            textoPuntuacion.text = "Puntuación: " + puntajeRedondeado.ToString();
        }
    }
}