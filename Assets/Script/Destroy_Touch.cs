using UnityEngine;
using System.Collections;

public class Destroy_Touch : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
