using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    float rotation = 0;

    public float camSpeed = 0.01f;

    private Vector3 rotateValue;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotateValue = new Vector3(0, 0, 1);
    }

    private void FixedUpdate()
    {
        fixedRotation();
    }

    void fixedRotation()
    {
        transform.eulerAngles = transform.eulerAngles - rotateValue;
        transform.eulerAngles += rotateValue * camSpeed;
    }
}
