using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    public float camSpeed = -5.0f;

    private Vector3 rotateValue;

    public float swingDuration = 2;

    public bool enableSwing = false;

    public bool enableFixedRotation = false;

    public bool reset = false;

    int stage = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotateValue = new Vector3(0, 0, 1);

        if(enableSwing)
        {
            if(swingDuration > 0)
            {
                swingDuration -= Time.deltaTime;
            }
            Debug.Log(swingDuration);
        }
    }

    private void FixedUpdate()
    {
        if (enableSwing)
        {
            swinging();          
        }

        if(enableFixedRotation)
        {
            fixedRotation();
        }

        if(reset)
        {
            resetRotation();
        }
    }

    void fixedRotation()
    {
        transform.eulerAngles = transform.eulerAngles - rotateValue;
        transform.eulerAngles += rotateValue * camSpeed;
    }

    void swinging()
    {
        if (swingDuration > 2)
        {
            transform.eulerAngles = transform.eulerAngles - rotateValue;
            transform.eulerAngles += rotateValue * camSpeed;
            
        }
        else 
        {
            transform.eulerAngles = transform.eulerAngles + rotateValue;
            transform.eulerAngles -= rotateValue * camSpeed;
        }

        if (swingDuration < 0)
        {
            swingDuration = 4;
        }
    }

    private void resetRotation()
    {
        enableFixedRotation = false;
        enableSwing = false;

        transform.eulerAngles = new Vector3(0, 0, 0);

        reset = false;
    }
}
