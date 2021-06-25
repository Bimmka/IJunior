using System.Collections;
using LevelBuilder;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private float _length;
    [SerializeField] private Vector3 _directionOffset;
    
    private Transform _ball;
    private Transform _kernel;
    
    private Vector3 _minimumBallPosition;

    private bool _isGameEnd;

    private void Awake()
    {
        BallJumper.OnSpawned += SetBall;
        Kernel.OnSpawned += SetKernel;
    }

    private void OnDestroy()
    {
        BallJumper.OnSpawned -= SetBall;
        Kernel.OnSpawned -= SetKernel;
    }

    private void SetBall(BallJumper ball)
    {
        _ball = ball.transform;
        _minimumBallPosition = _ball.position;
        if (_kernel != null)
            StartCoroutine(LookAtBall());
    }

    private void SetKernel(Kernel kernel)
    {
        _kernel = kernel.transform;
        if (_ball != null)
            StartCoroutine(LookAtBall());
    }
    
    private void CalculatePosition()
    { 
        Vector3 direction = (_kernel.position - _ball.position).normalized + _directionOffset;
        direction.y = _directionOffset.y;
        transform.position = _ball.position - direction * _length;
        transform.LookAt(_ball);
    }

    private IEnumerator LookAtBall()
    {
        while (!_isGameEnd)
        {
            
            if (_ball.position.y < _minimumBallPosition.y)
            {
                CalculatePosition();
                _minimumBallPosition.y = _ball.position.y;
            }
            yield return null;
        }
    }
}
