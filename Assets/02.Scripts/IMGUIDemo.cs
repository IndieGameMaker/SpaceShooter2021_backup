using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class IMGUIDemo : MonoBehaviour
{
    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 50), "SpaceShooter");

        if (GUI.Button(new Rect(10, 60, 100, 30), "START"))
        {
            Debug.Log("START button clicked !");
        }
    }
}
