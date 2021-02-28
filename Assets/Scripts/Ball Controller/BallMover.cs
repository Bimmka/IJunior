using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody))]
public class BallMover : MonoBehaviour
{
    [Tooltip("Максимальная скорость, с которой может двигаться шар")] 
    [SerializeField] private float _maxBallSpeed;

    private Rigidbody _ballBody;

    private FixedJoystick _fixedJoystick;

    [Inject]
    private void Construct(FixedJoystick joystick)
    {
        _fixedJoystick = joystick;
        _fixedJoystick.HandleUp += AddForceToBal;
    }
    private void Awake()
    {
        TryGetComponent(out _ballBody);
    }

    private void OnDisable()
    {
        
        _fixedJoystick.HandleUp -= AddForceToBal;
    }

    private void AddForceToBal(Vector3 direction)
    {
        Debug.Log(direction);
        _ballBody.AddForce(direction * _maxBallSpeed);
    }
}
