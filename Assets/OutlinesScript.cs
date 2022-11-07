using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinesScript : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;
    public GameObject left;
    public GameObject right;

    public Renderer topRen;
    public Renderer bottomRen;
    public Renderer leftRen;
    public Renderer rightRen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setupOutlinesSize(float width , float height)
    {
        top.gameObject.transform.localScale = new Vector3(width, 0.5f, 1);
        bottom.gameObject.transform.localScale = new Vector3(width, 0.5f, 1);
        left.gameObject.transform.localScale = new Vector3(0.5f, height, 1);
        right.gameObject.transform.localScale = new Vector3(0.5f, height, 1);
    }

    public void setupOutlinesColor(int colorChoice)
    {
        //Color color;

        //switch(colorChoice)
        //{
        //    case 0:
        //        color = Color.red;
        //        break;
        //    case 1:
        //        color = Color.green;
        //        break;
        //}

        topRen.material.color = Color.red;
        bottomRen.material.color = Color.red;
        leftRen.material.color = Color.red;
        rightRen.material.color = Color.red;
    }

    public void setupOutlinesPosition(float xPos, float yPos)
    {
        xPos = xPos / 2;
        yPos = yPos / 2;

        top.gameObject.transform.localPosition = new Vector3(0, yPos, 0);
        bottom.gameObject.transform.localPosition = new Vector3(0, -yPos, 0);
        left.gameObject.transform.localPosition = new Vector3(xPos, 0, 0);
        right.gameObject.transform.localPosition = new Vector3(-xPos, 0, 0);
    }
}
