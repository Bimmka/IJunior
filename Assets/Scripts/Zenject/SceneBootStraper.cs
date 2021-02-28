using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneBootStraper : MonoInstaller
{
    [Tooltip("Точка спавна шарика")] 
    [SerializeField] private Transform _spawnPoint;

    [Tooltip("Canvas, на котором будет висеть джойстик")] 
    [SerializeField] private RectTransform _canvas;

    [Tooltip("Joystick Prefab")] 
    [SerializeField] private GameObject _joystick;
    
    [Tooltip("Ball Prefab")] 
    [SerializeField] private GameObject _ball;

    private FixedJoystick _spawnedJoystick;
    public override void InstallBindings()
    {
        SpawnJoystick();
        SpawnBall();
    }

    private void SpawnBall()
    {
        Container.InstantiatePrefab(_ball,_spawnPoint);
        
    }

    private void SpawnJoystick()
    {
        _spawnedJoystick = Container.InstantiatePrefabForComponent<FixedJoystick>(_joystick, _canvas);
        Container.Bind<FixedJoystick>().FromInstance(_spawnedJoystick).AsSingle();
    }
}
