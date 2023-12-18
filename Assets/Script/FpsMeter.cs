using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsMeter : MonoBehaviour
{
    private float fps;
    void Update()
    {
        fps = Mathf.Round((1f / Time.unscaledDeltaTime));
    }
    private void OnGUI()
    {
        GUIStyle guiStyleLabel = new(GUI.skin.label)
        {
            fontSize = 48
        };

        GUI.Label(new Rect(0, 35, 500, 100), "FPS:" + fps, guiStyleLabel);

    }

}
