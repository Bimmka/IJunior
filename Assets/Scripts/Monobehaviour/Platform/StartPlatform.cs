using LevelBuilder;
using UnityEngine;

namespace Platforms
{
    public class StartPlatform : Platform
    {
        [SerializeField] private Transform _spawnPosition;
        [SerializeField] private BallJumper _ballPrefab;

        private void Awake()
        {
            KernelCreator.OnLevelCreated += SpawnBall;
        }

        private void OnDestroy()
        {
            KernelCreator.OnLevelCreated -= SpawnBall;
        }

        private void SpawnBall()
        {
            Instantiate(_ballPrefab, _spawnPosition.position, Quaternion.identity);
        }

        public override void Init(Vector3 position, Quaternion rotation, Transform parent)
        {
            base.Init(position, rotation, parent);
            transform.rotation = Quaternion.identity;
        }
    }
}

