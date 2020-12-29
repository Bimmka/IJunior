using System.Collections;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [Header("Интервал между спавнами кубов")]
    [SerializeField] private float _cubeSpawnInterval = 0.2f;

    private WaitForSeconds _cubeSpawnTime;

    private GameObject _cubePrefab;

    private void Awake()
    {
        _cubeSpawnTime = new WaitForSeconds(_cubeSpawnInterval);

        _cubePrefab = Resources.Load<GameObject>("Cubes/Cube");
    }

    private void Start()
    {
        StartCoroutine(SpawnCube());
    }

    private IEnumerator SpawnCube()
    {
        while(true)
        {
            Instantiate(_cubePrefab);
            yield return _cubeSpawnTime;
        }
    }
}
