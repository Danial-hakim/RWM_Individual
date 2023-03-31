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
    [SerializeField] bool rainEffect;
    GameObject rainGameobject;
    ParticleSystem rainParticles;

    [Header("Confetti Setter")]
    [SerializeField] bool confettiEffect;
    GameObject confettiGameobject;
    ParticleSystem confettiParticles;

    ParticleSystemShapeType edgeShape = ParticleSystemShapeType.SingleSidedEdge;

    float topOfScreen;
    float camSize;

    // Start is called before the first frame update
    void Start()
    {
        topOfScreen = Camera.main.orthographicSize;
        camSize = Camera.main.orthographicSize;

        snowGameobject = SetupParticle("Snow Particle");
        rainGameobject = SetupParticle("Rain Particle");
        confettiGameobject = SetupParticle("Confetti Particle");
    }

    // Update is called once per frame
    void Update()
    {
        ToggleParticleEffect(snowParticles, snowEffect);
        ToggleParticleEffect(rainParticles, rainEffect);
        ToggleParticleEffect(confettiParticles, confettiEffect);
    }

    void ToggleParticleEffect(ParticleSystem particleSystem, bool enable)
    {
        if (enable && !particleSystem.isPlaying)
        {
            particleSystem.Play();
        }
        else if (!enable && particleSystem.isPlaying)
        {
            particleSystem.Stop();
        }
    }

    GameObject SetupParticle(string particleName)
    {
        GameObject particleGameObject = transform.Find(particleName).gameObject;
        ParticleSystem particleSystem = particleGameObject.GetComponent<ParticleSystem>();

        particleGameObject.transform.position = new Vector3(0, topOfScreen, 0);

        var shape = particleSystem.shape;
        shape.shapeType = edgeShape;
        shape.radius = camSize * 2;

        return particleGameObject;
    }
    //void SetupSnow()
    //{
    //    snowGameobject = transform.Find("Snow Particle").gameObject;
    //    snowParticles = snowGameobject.GetComponent<ParticleSystem>();

    //    snowGameobject.transform.position = new Vector3(0, topOfScreen, 0);

    //    var shape = snowParticles.shape;
    //    shape.shapeType = edgeShape;
    //    shape.radius = camSize * 2;
    //}

    //void SetupRain()
    //{
    //    rainGameobject = transform.Find("Rain Particle").gameObject;
    //    rainParticles = rainGameobject.GetComponent<ParticleSystem>();

    //    rainGameobject.transform.position = new Vector3(0, topOfScreen, 0);

    //    var shape = rainParticles.shape;
    //    shape.shapeType = edgeShape;
    //    shape.radius = camSize * 2;
    //}

    //void SetupConfetti()
    //{
    //    confettiGameobject = transform.Find("Confetti Particle").gameObject;
    //    confettiParticles = confettiGameobject.GetComponent<ParticleSystem>();

    //    confettiGameobject.transform.position = new Vector3(0, topOfScreen, 0);

    //    var shape = confettiParticles.shape;
    //    shape.shapeType = edgeShape;
    //    shape.radius = camSize * 2;
    //}
}
