using System;
using System.Collections.Generic;
using Effects;
using UnityEngine;

namespace Tower
{
    [RequireComponent(typeof(TowerCreator))]
    public class TowerObserver : MonoBehaviour
    {
        [SerializeField] private EffectPool _effectPool;
        
        private TowerCreator _towerCreator;

        private List<Pipe> _pipes;

        public static event Action<int> OnPipeCountChanged;
        public static event Action OnGameFinished;

        private void Awake()
        {
            TryGetComponent(out _towerCreator);
            _pipes = _towerCreator.CreateTower();
            OnPipeCountChanged?.Invoke(_pipes.Count);
            for (int i = 0; i < _pipes.Count; i++)
            {
                _pipes[i].OnBreak += OnBreakPipe;
            }
        }

        private void OnBreakPipe(Pipe pipe)
        {
            pipe.OnBreak -= OnBreakPipe;
            pipe.gameObject.SetActive(false);
            _pipes.Remove(pipe);
            _effectPool.GetEffect().Init(pipe.Color);
            
            for (int i = 0; i < _pipes.Count; i++)
            {
                _pipes[i].transform.position = new Vector3(
                    _pipes[i].transform.position.x,
                    _pipes[i].transform.position.y - _pipes[i].transform.localScale.y, 
                    _pipes[i].transform.position.z);
            }
            OnPipeCountChanged?.Invoke(_pipes.Count);
            CheckForWin();
        }


        private void CheckForWin()
        {
            if (_pipes.Count <= 0)
                Win();
        }

        private void Win()
        {
            OnGameFinished?.Invoke();;
        }
    }

}
