using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlatformSegment : MonoBehaviour
{
    private Rigidbody _rigidbody;

    private float _timeToDisable = 1.5f;
    
    private void Awake()
    {
        TryGetComponent(out _rigidbody);
    }

    private IEnumerator WaitTiDisable()
    {
        yield return new WaitForSeconds(_timeToDisable);
        DisableObject();
    }

    private void DisableObject()
    {
        gameObject.SetActive(false);
    }

    public void Break(float explosionForce, Vector3 explosionCenter, float explosionRadius)
    {
        _rigidbody.isKinematic = false;
        _rigidbody.AddExplosionForce(explosionForce, explosionCenter, explosionRadius);
        StartCoroutine(WaitTiDisable());
    }
}
