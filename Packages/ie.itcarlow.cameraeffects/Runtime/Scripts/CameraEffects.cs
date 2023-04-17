using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraEffects : MonoBehaviour
{
    [Header("Snow Setter")]
    [SerializeField] bool snowEffect;
    GameObject snowGameobject;

    [Header("Rain Setter")]
    [SerializeField] bool rainEffect;
    GameObject rainGameobject;

    [Header("Confetti Setter")]
    [SerializeField] bool confettiEffect;
    GameObject confettiGameobject;

    [Header("Leaf Falling Setter")]
    [SerializeField] bool leafFallingEffect;
    GameObject leafGameobject;

    ParticleSystemShapeType edgeShape = ParticleSystemShapeType.SingleSidedEdge;

    float topOfScreen;
    float camSize;

    [SerializeField] bool enableGrayscaleEffect = false;
    [SerializeField] Material grayscaleMaterial;

    // Start is called before the first frame update
    void Start()
    {
        topOfScreen = Camera.main.orthographicSize;
        camSize = Camera.main.orthographicSize;

        snowGameobject = SetupParticle("Snow Particle");
        rainGameobject = SetupParticle("Rain Particle");
        confettiGameobject = SetupParticle("Confetti Particle");
        leafGameobject = SetupParticle("Leaf Particle");
    }

    // Update is called once per frame
    void Update()
    {
        ToggleParticleEffect(snowGameobject, snowEffect);
        ToggleParticleEffect(rainGameobject, rainEffect);
        ToggleParticleEffect(confettiGameobject, confettiEffect);
        ToggleParticleEffect(leafGameobject, leafFallingEffect);
    }

    void ToggleParticleEffect(GameObject currentGameobject, bool enable)
    {
        ParticleSystem particleSystem = currentGameobject.GetComponent<ParticleSystem>();
        if(particleSystem != null)
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
    }

    GameObject SetupParticle(string particleName)
    {
        Transform particleTransform = transform.Find(particleName);
        GameObject particleGameObject = particleTransform.gameObject;
        ParticleSystem particleSystem = particleGameObject.GetComponent<ParticleSystem>();

        particleGameObject.transform.position = new Vector3(0, topOfScreen, 0);

        var shape = particleSystem.shape;
        shape.shapeType = edgeShape;
        shape.radius = camSize * 2;

        return particleGameObject;
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (enableGrayscaleEffect)
        {
            Graphics.Blit(source, destination, grayscaleMaterial);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}
