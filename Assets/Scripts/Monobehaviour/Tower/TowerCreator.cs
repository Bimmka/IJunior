using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Tower
{
    public class TowerCreator : MonoBehaviour
    {
        [SerializeField] private Vector2Int _towerSizeRange;
        [SerializeField] private Pipe _pipePrefab;

        public List<Pipe> CreateTower()
        {
            List<Pipe> pipes = new List<Pipe>();
            int towerSize = Random.Range(_towerSizeRange.x, _towerSizeRange.y);
            Transform currentPoint = transform;
            
            for (int i = 0; i < towerSize; i++)
            {
                pipes.Add(CreatePipe(currentPoint));
                currentPoint = pipes.Last().transform;
            }

            return pipes;
        }

        private Pipe CreatePipe(Transform currentPoint)
        {
            return Instantiate(_pipePrefab, GetSpawnPosition(currentPoint), Quaternion.identity, transform);
        }

        private Vector3 GetSpawnPosition(Transform currentPoint)
        {
            return new Vector3(
                transform.position.x, 
                currentPoint.position.y + currentPoint.localScale.y / 2 + _pipePrefab.transform.localScale.y / 2,
                transform.position.z);
        }
    }
}
