using UnityEngine;
using System.Collections;

public class Generate_People : MonoBehaviour
{
    public GameObject[] people;
    public float tiempoMin, tiempoMax;
    // Use this for initialization

    void Start()
    {
        Generar();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Generar()
    {
        int indice = Random.Range(0, people.Length);
        Instantiate(people[indice], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
    }
}
