using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    [Tooltip("Prefab кегли")] 
    [SerializeField] private GameObject _bowlingPin;

    private void OnEnable()
    {
        Instantiate(_bowlingPin, transform.position, _bowlingPin.transform.rotation, transform);
    }
}
