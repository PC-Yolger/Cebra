using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour
{

    public GUISkin[] guiskin;

    void OnGUI()
    {
        if (guiskin[0] != null)
        {
            GUI.skin = guiskin[0];
            if (GUI.Button(new Rect(Screen.width - 180, 10, 170, 90), ""))
            {
                Application.LoadLevel("level");
            }
        }
        if (guiskin[1] != null)
        {
            GUI.skin = guiskin[1];
            if (GUI.Button(new Rect(Screen.width - 180, 110, 170, 90), ""))
            {
                Application.LoadLevel("Creditos");
            }
        }
        if (guiskin[2] != null)
        {
            GUI.skin = guiskin[2];
            if (GUI.Button(new Rect(Screen.width - 180, 210, 170, 90), ""))
            {
                Application.Quit();
            }
        }
    }
}
