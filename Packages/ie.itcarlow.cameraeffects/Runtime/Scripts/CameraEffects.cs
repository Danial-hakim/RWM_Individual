using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    [SerializeField] bool SnowEffect;
    GameObject snowGameobject;
    ParticleSystem snowParticles;
    ParticleSystemShapeType edgeShape = ParticleSystemShapeType.SingleSidedEdge;

    float topOfScreen;
    float camSize;

    // Start is called before the first frame update
    void Start()
    {
        topOfScreen = Camera.main.orthographicSize;
        camSize = Camera.main.orthographicSize;

        SetupSnow();
    }

    // Update is called once per frame
    void Update()
    {
        if(SnowEffect)
        {
            if(!snowParticles.isPlaying)
            {
                snowParticles.Play();
            }
        }
        else
        {
            if(snowParticles.isPlaying)
            {
                snowParticles.Stop();
            }
        }
    }

    void SetupSnow()
    {
        snowGameobject = transform.GetChild(0).gameObject;
        snowParticles = snowGameobject.GetComponent<ParticleSystem>();

        snowGameobject.transform.position = new Vector3(0, topOfScreen, 0);

        var shape = snowParticles.shape;
        shape.shapeType = edgeShape;
        shape.radius = camSize * 2;
    }
}
