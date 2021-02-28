using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PinSpawner : MonoBehaviour
{
    [Tooltip("Prefab кегли")] 
    [SerializeField] private GameObject _bowlingPin;
    
//    [SerializeField] private 
    [SerializeField] private InputAction _inputActions;

    private void Awake()
    {
        _inputActions.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Disable();
    }

    private void Update()
    {
        if (_inputActions.triggered) Spawn();
    }


    private void Spawn()
    {
        Instantiate(_bowlingPin, transform.position, _bowlingPin.transform.rotation, transform);
    }
    
}
