using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour
{
    public float speed = 0.0f;

    void Update()
    {
        GameObject game = GameObject.Find("State");
        if (!game.transform.GetComponent<State>().GetDead())
        {
            renderer.material.mainTextureOffset = new Vector2(Time.time * speed, 0.0f);
        }
    }
}
