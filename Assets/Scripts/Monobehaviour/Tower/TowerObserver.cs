using System.Collections.Generic;
using UnityEngine;

namespace Tower
{
    [RequireComponent(typeof(TowerCreator))]
    public class TowerObserver : MonoBehaviour
    {
        private TowerCreator _towerCreator;

        private List<Pipe> _pipes;

        private void Awake()
        {
            TryGetComponent(out _towerCreator);
            _pipes = _towerCreator.CreateTower();
        }
    }

}
