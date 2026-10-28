using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour
{
    public void VolverAlJuego()
    {
        SceneManager.LoadScene(0);
    }
}