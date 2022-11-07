using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    public int speed = 2;
    public Rigidbody2D rb;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        gameObject.transform.position += Vector3.left * speed * Time.deltaTime;

        if (timer >= 20.0f)
        {
            timer = 0.0f;
            speed += 1;
        }

    }
}
