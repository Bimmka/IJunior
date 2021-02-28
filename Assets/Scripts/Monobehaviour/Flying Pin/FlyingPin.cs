using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class FlyingPin : MonoBehaviour
{
    [Tooltip("Точки, по которым летит кегля")] 
    [SerializeField] private Transform[] _wayPoints;

    [Tooltip("Prefab шара")] 
    [SerializeField] private GameObject _ball;

    [Tooltip("Интервал между спавнами")]
    [SerializeField] private float _spawnInterval;

    private WaitForSeconds _spawnTime;

    private int _currentWayPointIndex = 0;

    private float _flyTimeBetweenPoints = 2f;

    private void Awake()
    {
        _spawnTime = new WaitForSeconds(_spawnInterval);
        MoveToTarget();
        StartCoroutine(SpawnBall());
    }

    private void MoveToTarget()
    {
        transform.DOMove(_wayPoints[_currentWayPointIndex].position, _flyTimeBetweenPoints).SetEase(Ease.InOutSine)
            .OnComplete(ChangeIndex);
    }

    private void ChangeIndex()
    {
        _currentWayPointIndex++;
        _currentWayPointIndex %= _wayPoints.Length;
        MoveToTarget();
    }

    private IEnumerator SpawnBall()
    {
        while (true)
        {
            Instantiate(_ball, transform.position, _ball.transform.rotation);
            yield return _spawnTime;
        }
    }
}
