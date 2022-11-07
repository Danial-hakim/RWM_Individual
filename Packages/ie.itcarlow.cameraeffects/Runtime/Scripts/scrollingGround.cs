using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollingGround : MonoBehaviour
{
    public BoxCollider2D groundCol;

    int speed = 7;
    float width;
    // Start is called before the first frame update
    void Start()
    {
        groundCol = GetComponent<BoxCollider2D>();
        width = groundCol.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x <= -18)
        {
            Vector3 resetPos = new Vector3(36, 0, 0);

            transform.position += resetPos;
        }
    }
}
