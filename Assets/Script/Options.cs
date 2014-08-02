using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour
{
    private bool paused = false;

    public GUISkin guiskin;

    void Update()
    {
        if (paused)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }

    void OnGUI()
    {
        if (guiskin != null)
        {
            GUI.skin = guiskin;
            if (GUI.Button(new Rect(Screen.width - 85, 10, 75, 75), ""))
            {
                GameObject game = GameObject.Find("State");
                paused = !paused;
                game.transform.GetComponent<State>().SetPause(paused);
            }
        }
    }
}
