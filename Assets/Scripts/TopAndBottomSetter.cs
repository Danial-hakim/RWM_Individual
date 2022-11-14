using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopAndBottomSetter : MonoBehaviour
{
    public GameObject firstLayer;
    public GameObject secondLayer;
    public GameObject thirdLayer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setupOutlinesSize(float width)
    {
        firstLayer.gameObject.transform.localScale = new Vector3(width , 0.5f, 1);
        secondLayer.gameObject.transform.localScale = new Vector3(width, 0.5f, 1);
        thirdLayer.gameObject.transform.localScale = new Vector3(width, 0.5f, 1);
    }

    public void setupOutlinesColor()
    {
        Color firstRed = new Color(1, 0, 0, 0.66f);
        Color secondRed = new Color(1.0f, 0.0f, 0.0f, 0.33f);
        Color thirdRed = new Color(1, 0, 0, 0.11f);

        firstLayer.GetComponent<Renderer>().material.color = firstRed;
        secondLayer.GetComponent<Renderer>().material.color = secondRed;
        thirdLayer.GetComponent<Renderer>().material.color = thirdRed;
    }

    public void setupOutlinesPosition(int minus) 
    {
        Vector3 parentPos = firstLayer.transform.parent.localPosition;

        firstLayer.gameObject.transform.localPosition = new Vector3(parentPos.x,parentPos.y , 0);
        secondLayer.gameObject.transform.localPosition = new Vector3(parentPos.x, parentPos.y - (0.2f * minus), 0);
        thirdLayer.gameObject.transform.localPosition = new Vector3(parentPos.x, parentPos.y - (0.3f * minus), 0);
    }

    public void setToTransparent()
    {
        Color transparent = new Color(0, 0, 0, 0);

        firstLayer.GetComponent<Renderer>().material.color = transparent;
        secondLayer.GetComponent<Renderer>().material.color = transparent;
        thirdLayer.GetComponent<Renderer>().material.color = transparent;
    }
}
