using UnityEngine;
using System.Collections;

public class Menu_Button : MonoBehaviour
{

    public GUISkin Skin;

    void OnGUI()
    {
        if (Skin != null)
        {
            GUI.skin = Skin;
            if (GUI.Button(new Rect(Screen.width - 85, 10, 75, 75), ""))
            {
                Application.LoadLevel("MenuPrincipal");
            }
        }
    }
}
