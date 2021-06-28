using System;
using UnityEngine;

namespace Tower
{
    public class Pipe : MonoBehaviour
    {
        private MeshRenderer _renderer;
        public event Action<Pipe> OnBreak;

        public Color Color => _renderer.material.color;

        private void Awake()
        {
            TryGetComponent(out _renderer);
        }

        public void Break()
        {
            OnBreak?.Invoke(this);
        }

        public void SetColor(Color color)
        {
            _renderer.material.color = color;
        }
    }
}

