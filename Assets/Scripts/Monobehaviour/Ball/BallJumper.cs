using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallJumper : MonoBehaviour
{
    [SerializeField] private float _jumpForce;

    private Rigidbody _rigidbody;

    private Coroutine _addForceCoroutine;

    public static event Action<BallJumper> OnSpawned;

    private void Awake()
    {
        TryGetComponent(out _rigidbody);
        
    }

    private void Start()
    {
        OnSpawned?.Invoke(this);
    }

    private IEnumerator WaitToAddForce()
    {
        Jump();
        yield return new WaitForFixedUpdate();
        _addForceCoroutine = null;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.GetComponent<PlatformSegment>() != null && _addForceCoroutine == null)
            _addForceCoroutine = StartCoroutine(WaitToAddForce());
    }

    private void Jump()
    {
        _rigidbody.AddForce(Vector3.up*_jumpForce);
    }
}
