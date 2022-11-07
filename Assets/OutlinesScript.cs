using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinesScript : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;

    public TopAndBottomSetter topParent;
    public TopAndBottomSetter bottomParent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void setOutlinesParentSize(float width, float height)
    {
        topParent.setupOutlinesSize(width);
        bottomParent.setupOutlinesSize(width);
    }

    public void setOutlineParentColor(int colorChoice)
    {
        topParent.setupOutlinesColor();
        bottomParent.setupOutlinesColor();
    }

    public void setOutlineParentPos(float xPos, float yPos)
    {
        xPos = xPos / 2;
        yPos = yPos / 2;

        top.gameObject.transform.localPosition = new Vector3(0, yPos, 0);
        bottom.gameObject.transform.localPosition = new Vector3(0, -yPos, 0);

        topParent.setupOutlinesPosition(1);
        bottomParent.setupOutlinesPosition(-1);
    }

    public void turnOffRenderer()
    {
        topParent.setToTransparent();
        bottomParent.setToTransparent();
    }
}
