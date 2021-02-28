using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectSpawnerActivator : MonoBehaviour
{
    [Tooltip("Объекты, которые буду спавнить спавнеры")] 
    [SerializeField] private GameObject[] _objectsForSpawn;

    [Tooltip("Интервал между спавнами")] 
    [SerializeField] private float _spawnInterval;

    private WaitForSeconds _spawnTime;
    
    private IObjectSpawner[] _objectSpawners;

    private void Awake()
    {
        _objectSpawners = GetComponentsInChildren<IObjectSpawner>().ToArray();
        _spawnTime = new WaitForSeconds(_spawnInterval);
    }

    private void Start()
    {
        StartCoroutine(SpawnObject());
    }

    private IEnumerator SpawnObject()
    {
        while (true)
        {
            yield return _spawnTime;
            _objectSpawners[Random.Range(0,_objectSpawners.Length)].SpawnObject(_objectsForSpawn[Random.Range(0,_objectsForSpawn.Length)]);
        }
    }
}
