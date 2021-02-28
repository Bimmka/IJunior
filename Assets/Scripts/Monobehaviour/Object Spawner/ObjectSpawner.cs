using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObjectSpawner : MonoBehaviour
{
    [Tooltip("Объекты, которые буду спавнить спавнеры")] 
    [SerializeField] private GameObject[] _objectsForSpawn;

    [Tooltip("Интервал между спавнами")] 
    [SerializeField] private float _spawnInterval;
    
    [Tooltip("Точки спавна")]
    [SerializeField] private Transform[] _objectSpawners;

    private WaitForSeconds _spawnTime;
    
   

    private void Awake()
    {
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
            Instantiate(_objectsForSpawn[Random.Range(0,_objectsForSpawn.Length)], _objectSpawners[Random.Range(0,_objectSpawners.Length)]);
        }
    }
}
