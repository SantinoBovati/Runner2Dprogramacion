using UnityEngine;

public class ObstaculosSpawner : MonoBehaviour
{

    public GameObject[] arreglodeObjetos;
    public float delay = 2f;
    public float tiempoRepeticion = 2f;
    public Vector2 spawnPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnMultiple", delay, tiempoRepeticion);
    }


    void SpawnMultiple()
    {
        int indiceAleatorio = Random.Range(0, arreglodeObjetos.Length);
        GameObject obstaculosAleatorios = arreglodeObjetos[indiceAleatorio];
        Instantiate(obstaculosAleatorios, spawnPosition, Quaternion.identity);
    }
}