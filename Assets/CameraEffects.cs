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

        outlines.setupOutlinesSize(cameraWidth, cameraHeight);
        outlines.setupOutlinesPosition(cameraWidth, cameraHeight);
        outlines.setupOutlinesColor(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
