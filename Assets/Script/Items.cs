using UnityEngine;
using System.Collections;

public class Items : MonoBehaviour
{
    public GameObject audio;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject game = GameObject.Find("State");
        if (other.tag == "Player")
        {
            Instantiate(audio);
            game.transform.GetComponent<State>().SetScore(1);
            Destroy(gameObject);
        }
    }
}
