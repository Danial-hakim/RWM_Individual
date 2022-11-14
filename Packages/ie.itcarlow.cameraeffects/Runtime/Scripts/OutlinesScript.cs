using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinesScript : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;

    public TopAndBottomSetter topParent;
    public TopAndBottomSetter bottomParent;

    public Camera cam;

    float height;
    float width;

    public float timer = 2.5f;
    // Start is called before the first frame update
    private void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                topParent.setToTransparent();
                bottomParent.setToTransparent();
            }
        }
    }

    public void setOutlinesParentSize()
    {
        height = cam.orthographicSize * 2f;
        width = height * cam.aspect;

        gameObject.transform.position = new Vector3(cam.transform.position.x, cam.transform.position.y, cam.transform.position.z + 2);

        topParent.setupOutlinesSize(width);
        bottomParent.setupOutlinesSize(width);
    }

    public void setOutlineParentColor()
    {
        topParent.setupOutlinesColor();
        bottomParent.setupOutlinesColor();
    }

    public void setOutlineParentPos()
    {
        float xPos = 0;
        float yPos = height / 4;

        top.gameObject.transform.localPosition = new Vector3(xPos, yPos, 10);
        bottom.gameObject.transform.localPosition = new Vector3(xPos, -yPos, 10);

        topParent.setupOutlinesPosition(1);
        bottomParent.setupOutlinesPosition(-1);
    }

    public void checkState()
    {

    }

    public void initiate()
    {
        gameObject.SetActive(true);
        setOutlinesParentSize();
        setOutlineParentColor();
        setOutlineParentPos();
        //checkState();
    }
}
