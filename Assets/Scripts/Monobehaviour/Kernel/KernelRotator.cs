using UnityEngine;

public class KernelRotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    [SerializeField] private Rigidbody _rigidbody;

    private void Update()
    {
#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            Touch currentTouch = Input.GetTouch(0);
            if (currentTouch.phase == TouchPhase.Moved)
            {
                _rigidbody.AddTorque(Vector3.up * (_rotateSpeed * Time.deltaTime * currentTouch.deltaPosition.x));
            }
           
        }
#endif
    }
}
