using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlinesScript : MonoBehaviour
{
    public GameObject top;
    public GameObject bottom;

#pragma warning disable CS0436 // Type conflicts with imported type
    TopAndBottomSetter topParent;
    TopAndBottomSetter bottomParent;
#pragma warning restore CS0436 // Type conflicts with imported type

    [SerializeField]private Camera cam;

    float height;
    float width;

    public float timer = 2.5f;
    // Start is called before the first frame update

    void Start()
    {
#pragma warning disable CS0436 // Type conflicts with imported type
        topParent = top.GetComponent<TopAndBottomSetter>();
        bottomParent = bottom.GetComponent<TopAndBottomSetter>();
#pragma warning restore CS0436 // Type conflicts with imported type
        setOutlinesParentSize();
        setOutlineParentColor();
        setOutlineParentPos();

        if(cam == null)
        {
            cam = Camera.main;
        }

        transform.parent = null;
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

    public void setCamera(Camera camera)
    {
        cam = camera;
    }
}
