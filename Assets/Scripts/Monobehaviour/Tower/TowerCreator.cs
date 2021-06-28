using System.Collections.Generic;
using UnityEngine;

namespace Tower
{
    public class TowerCreator : MonoBehaviour
    {
        [SerializeField] private Vector2Int _towerSizeRange;
        [SerializeField] private Pipe _pipePrefab;
        [SerializeField] private Color[] _colors;

        public List<Pipe> CreateTower()
        {
            List<Pipe> pipes = new List<Pipe>();
            int towerSize = Random.Range(_towerSizeRange.x, _towerSizeRange.y);
            Transform currentPoint = transform;
            
            for (int i = 0; i < towerSize; i++)
            {
                pipes.Add(CreatePipe(currentPoint));
                currentPoint = pipes[pipes.Count-1].transform;
            }

            return pipes;
        }

        private Pipe CreatePipe(Transform currentPoint)
        {
            Pipe createdPipe = Instantiate(_pipePrefab, GetSpawnPosition(currentPoint), Quaternion.identity, transform);
            createdPipe.SetColor(_colors[Random.Range(0,_colors.Length)]);
            return createdPipe;
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
