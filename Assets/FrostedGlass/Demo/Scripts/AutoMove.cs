using UnityEngine;
namespace AutoMove
{
    public class AutoMove : MonoBehaviour
    {
        public float Speed = 1.0f;

        public Transform PointStart;
        public Transform PointEnd;

        void Start()
        {
            transform.position = PointStart.position;
        }

        void Update()
        {
            float deltaTime = Mathf.PingPong(Time.time * Speed, 1);

            transform.position = Vector3.Lerp(
                PointStart.position,
                PointEnd.position,
                deltaTime
            );

            Vector3 rotFactor = Vector3.one * rotateSpeed;

            if (!RotateOnX) rotFactor.x = 0;
            if (!RotateOnY) rotFactor.y = 0;
            if (!RotateOnZ) rotFactor.z = 0;

            transform.Rotate(
                rotFactor * Time.deltaTime
           ); 
        }
        public float rotateSpeed = 8.0f;

        public bool RotateOnX = true;
        public bool RotateOnY = true;
        public bool RotateOnZ = true;
    }
}
