using UnityEngine;
using System.Collections;

public class Destroy_Time : MonoBehaviour
{
    public float lifetime;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }
}
