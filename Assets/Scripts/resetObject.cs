using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetObject : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x < -9.5)
        {
            gameObject.transform.position = new Vector3(8.0f, transform.position.y, transform.position.z);
        }
    }
}
