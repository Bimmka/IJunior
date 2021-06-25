using System;
using System.Collections.Generic;
using Platforms;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

namespace LevelBuilder
{
    public class KernelCreator : MonoBehaviour
    {
        [Tooltip("Диапазон количества уровней")]
        [SerializeField] private Vector2Int _levelCountRange;
        
        [Tooltip("Расстояние между платформами")]
        [SerializeField] private float _height;
        
        [Tooltip("Значение, на которое сдвигаем начальную точку спавна")]
        [SerializeField] private float additionalHeight = 0.5f;
        
        [Tooltip("Prefab стержня башни")]
        [SerializeField] private Kernel _kernel;
        
        [Tooltip("Префаб стартовой платформы")]
        [SerializeField] private StartPlatform _startPlatform;

        [Tooltip("Префаб финишной платформы")]
        [SerializeField] private FinishPlatform _finishPlatform;
        
        [Tooltip("Префабы платформ-препятствий")]
        [SerializeField] private ObstaclePlatform[] _obstaclePlatforms;
        
        private int _currentLevelCount;
        
        private Queue<Platform> _platformsForSpawn = new Queue<Platform>();

        private Kernel _createdKernel;

        public static event Action OnLevelCreated;
        
        private void Awake()
        {
            CalculateLevelCount();
            CreateKernel();
            CreatePlatformsQueue();
            SpawnPlatforms();
        }

        private void Start()
        {
            FinishCreate();
        }

        private void CalculateLevelCount()
        {
            _currentLevelCount = Random.Range(_levelCountRange.x, _levelCountRange.y);
        }

        private void CreateKernel()
        {
            _createdKernel = Instantiate(_kernel, transform);
            _createdKernel.Init( (_currentLevelCount  * _height/2) + additionalHeight * 2);
        }

        private void CreatePlatformsQueue()
        {
            _platformsForSpawn.Enqueue(_startPlatform);
            for (int i = 0; i < _currentLevelCount; i++)
            {
                _platformsForSpawn.Enqueue(_obstaclePlatforms[Random.Range(0,_obstaclePlatforms.Length)]);
            }
            _platformsForSpawn.Enqueue(_finishPlatform);
            
        }

        private void SpawnPlatforms()
        {
            Vector3 _spawnPosition = _createdKernel.transform.position;
            _spawnPosition += Vector3.up * (_createdKernel.transform.localScale.y - additionalHeight);
            float maxY = _createdKernel.transform.position.y + _createdKernel.transform.localScale.y;
            float minY = _createdKernel.transform.position.y - _createdKernel.transform.localScale.y;
            while (_platformsForSpawn.Count > 1)
            {
                SpawnPlatform(_platformsForSpawn.Dequeue(), ref _spawnPosition, _createdKernel.transform);
                _spawnPosition.y = Mathf.Clamp(_spawnPosition.y, minY, maxY);
            }
            SpawnPlatform(_platformsForSpawn.Dequeue(), _createdKernel.transform.position - Vector3.up*_createdKernel.transform.localScale.y, _createdKernel.transform); ;
        }

        private void SpawnPlatform(Platform platform, ref Vector3 spawnPosition, Transform parent)
        {
            SpawnPlatform(platform, spawnPosition, parent);
            spawnPosition -= Vector3.up * _height;
            
        }
        
        private void SpawnPlatform(Platform platform, Vector3 spawnPosition, Transform parent)
        {
            Platform _createdPlatform = Instantiate(platform);
            _createdPlatform.Init(spawnPosition, Quaternion.Euler(0,Random.Range(0,360),0), parent);
        }

        private void FinishCreate()
        {
            OnLevelCreated?.Invoke();
        }



#if  UNITY_EDITOR
        private void OnValidate()
        {
            LoadPlatform(ref _startPlatform, "Start Platform");
            LoadPlatform(ref _finishPlatform, "Finish Platform");
            _obstaclePlatforms = LoadPlatform<ObstaclePlatform>("Obstacle Platform");
        }

        private void LoadPlatform<T>(ref T platform, string fileName) where T : Platform
        {
            string[] assetNames = AssetDatabase.FindAssets(fileName, new[] { "Assets/Prefabs/Platforms" });
            platform = AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(assetNames[0]));
        }

        private T[] LoadPlatform<T>( string fileName) where T: Platform
        {
            string[] assetNames = AssetDatabase.FindAssets(fileName, new[] { "Assets/Prefabs/Platforms" });
            T[] platforms = new T[assetNames.Length];
            for (int i = 0; i < assetNames.Length; i++)
            {
                platforms[i] = AssetDatabase.LoadAssetAtPath<T>(AssetDatabase.GUIDToAssetPath(assetNames[i]));
            }
            return platforms;
        }
#endif
        
        
    }

}
