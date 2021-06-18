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
        [SerializeField] private Vector2Int levelCountRange;
        
        [Tooltip("Расстояние между платформами")]
        [SerializeField] private float height;
        
        [Tooltip("Prefab стержня башни")]
        [SerializeField] private Kernel kernel;
        
        [Tooltip("Префаб стартовой платформы")]
        [SerializeField] private StartPlatform startPlatform;
        
        [Tooltip("Префаб финишной платформы")]
        [SerializeField] private FinishPlatform finishPlatform;
    
        [Tooltip("Префабы платформ-препятствий")]
        [SerializeField] private ObstaclePlatform[] obstaclePlatforms;

        private int currentLevelCount;
        
        private Queue<Platform> platformsForSpawn = new Queue<Platform>();

        private Kernel createdKernel;
        
        private void Awake()
        {
            CalculateLevelCount();
            CreateKernel();
            CreatePlatformsQueue();
            SpawnPlatforms();
        }

        private void CalculateLevelCount()
        {
            currentLevelCount = Random.Range(levelCountRange.x, levelCountRange.y);
        }

        private void CreateKernel()
        {
            createdKernel = Instantiate(kernel, transform);
            createdKernel.Init( (currentLevelCount - 2)/ height );
        }

        private void CreatePlatformsQueue()
        {
            platformsForSpawn.Enqueue(startPlatform);
            for (int i = 0; i < currentLevelCount; i++)
            {
                platformsForSpawn.Enqueue(obstaclePlatforms[Random.Range(0,obstaclePlatforms.Length)]);
            }
            platformsForSpawn.Enqueue(finishPlatform);
            
        }

        private void SpawnPlatforms()
        {
            Vector3 spawnPosition = createdKernel.transform.position;
            spawnPosition += Vector3.up * createdKernel.transform.localScale.y;
            float maxY = createdKernel.transform.position.y + createdKernel.transform.localScale.y;
            float minY = createdKernel.transform.position.y - createdKernel.transform.localScale.y;
            while (platformsForSpawn.Count > 0)
            {
                SpawnPlatform(platformsForSpawn.Dequeue(), ref spawnPosition, createdKernel.transform);
                spawnPosition.y = Mathf.Clamp(spawnPosition.y, minY, maxY);
            }
        }

        private void SpawnPlatform(Platform platform, ref Vector3 spawnPosition, Transform parent)
        {
            Platform createdPlatform = Instantiate(platform);
            createdPlatform.Init(spawnPosition, Quaternion.Euler(0,Random.Range(0,360),0), parent);
            spawnPosition -= Vector3.up * height;
            
        }



#if  UNITY_EDITOR
        private void OnValidate()
        {
            LoadPlatform(ref startPlatform, "Start Platform");
            LoadPlatform(ref finishPlatform, "Finish Platform");
            obstaclePlatforms = LoadPlatform<ObstaclePlatform>("Obstacle Platform");
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
