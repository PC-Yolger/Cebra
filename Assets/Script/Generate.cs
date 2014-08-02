using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour
{

    public GameObject[] obj;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;

    float x;

    // Use this for initialization
    void Start()
    {
        Generar();
        x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Generar()
    {
        int indice = Random.Range(0, 10);
        x += 20;
        Vector3 vector = new Vector3(x, transform.position.y);
        if (indice < 5)
        {
            Instantiate(obj[0], vector, Quaternion.identity);
        }
        if (indice >= 5 || indice <= 10)
        {
            Instantiate(obj[1], vector, Quaternion.identity);
        }
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }
}
