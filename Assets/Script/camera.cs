using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour
{

    private Transform cam;
    public float distancia;

    // Use this for initialization
    void Start()
    {
        cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject game = GameObject.Find("State");
        if (!game.transform.GetComponent<State>().GetDead())
        {
            cam.position = new Vector3(transform.position.x + distancia, cam.position.y, cam.position.z);
        }
    }
}
