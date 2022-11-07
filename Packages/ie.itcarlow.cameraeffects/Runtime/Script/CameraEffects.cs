using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    float cameraHeight;
    float cameraWidth;

    public OutlinesScript outlines;

    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;

        cameraHeight = 2f * cam.orthographicSize;
        cameraWidth = cameraHeight * cam.aspect;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void drawOutlines()
    {
        float ypos = cameraHeight / 2;
        float xpos = cameraWidth / 2;

        outlines.setOutlinesParentSize(cameraWidth, cameraHeight);
        outlines.setOutlineParentPos(xpos, ypos);
        outlines.setOutlineParentColor(1);
    }

    public void turnOffRenderer()
    {
        outlines.turnOffRenderer();
    }
}
