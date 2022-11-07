using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopAndBottomSetter : MonoBehaviour
{
    public GameObject firstLayer;
    public GameObject secondLayer;
    public GameObject thirdLayer;

    public Renderer firstRen;
    public Renderer secondRen;
    public Renderer thirdRen;

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

        firstRen.material.color = firstRed;
        secondRen.material.color = secondRed;
        thirdRen.material.color = thirdRed;
    }

    public void setupOutlinesPosition(int minus) 
    {
        Vector3 parentPos = firstLayer.transform.parent.localPosition;

        firstLayer.gameObject.transform.localPosition = new Vector3(parentPos.x,parentPos.y ,parentPos.z);
        secondLayer.gameObject.transform.localPosition = new Vector3(parentPos.x, parentPos.y - (0.2f * minus), parentPos.z);
        thirdLayer.gameObject.transform.localPosition = new Vector3(parentPos.x, parentPos.y - (0.3f * minus), parentPos.z);
    }

    public void setToTransparent()
    {
        Color transparent = new Color(0, 0, 0, 0);

        firstRen.material.color = transparent;
        secondRen.material.color = transparent;
        thirdRen.material.color = transparent;
    }
}
