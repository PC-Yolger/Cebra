using UnityEngine;
using System.Collections;

public class Tea : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject game = GameObject.Find("State");
        if (other.tag == "Player")
        {
            game.transform.GetComponent<State>().SetTea(1500);
            Destroy(gameObject);
        }
    }
}
