using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    float cameraHeight;
    float cameraWidth;

    float ypos;
    float xpos;

    // Start is called before the first frame update
    void Start()
    {
        Camera cam = Camera.main;

        cameraHeight = 2f * cam.orthographicSize;
        cameraWidth = cameraHeight * cam.aspect;

        ypos = cameraHeight / 2;
        xpos = cameraWidth / 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector2 getSize()
    {
        return new Vector2(cameraWidth, cameraHeight);
    }

    public Vector2 getPos()
    {
        return new Vector2(xpos, ypos);
    }
}
