using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{

    public GameObject obstacles;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(obstacles, new Vector3(8f, -3.2f, 0f), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
