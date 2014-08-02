using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour
{

    public GUISkin[] guiskin;

    void OnGUI()
    {
        if (guiskin[0] != null)
        {
            GUI.skin = guiskin[0];
            if (GUI.Button(new Rect(Screen.width - 180, 10, 170, 90), ""))
            {
                Application.LoadLevel("MenuPrincipal");
            }
        }
    }
}
