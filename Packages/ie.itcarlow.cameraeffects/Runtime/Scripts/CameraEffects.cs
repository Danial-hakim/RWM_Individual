using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    [Header("Snow Setter")]
    [SerializeField] bool snowEffect;
    GameObject snowGameobject;
    ParticleSystem snowParticles;

    [Header("Rain Setter")]
    [SerializeField] bool RainEffect;
    GameObject rainGameobject;
    ParticleSystem rainParticles;

    ParticleSystemShapeType edgeShape = ParticleSystemShapeType.SingleSidedEdge;

    float topOfScreen;
    float camSize;

    // Start is called before the first frame update
    void Start()
    {
        topOfScreen = Camera.main.orthographicSize;
        camSize = Camera.main.orthographicSize;

        SetupSnow();
        SetupRain();
    }

    // Update is called once per frame
    void Update()
    {
        if(snowEffect)
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

        if (RainEffect)
        {
            if (!rainParticles.isPlaying)
            {
                rainParticles.Play();
            }
        }
        else
        {
            if (rainParticles.isPlaying)
            {
                rainParticles.Stop();
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

    void SetupRain()
    {
        rainGameobject = transform.GetChild(1).gameObject;
        rainParticles = rainGameobject.GetComponent<ParticleSystem>();

        rainGameobject.transform.position = new Vector3(0, topOfScreen, 0);

        var shape = rainParticles.shape;
        shape.shapeType = edgeShape;
        shape.radius = camSize * 2;
    }
}
