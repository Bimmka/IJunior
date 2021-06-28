using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    [RequireComponent(typeof(ParticleSystem))]
    public class Effect : MonoBehaviour
    {
        private ParticleSystem _particleSystem;
        private ParticleSystemRenderer _particleSystemRenderer;
        
        public event Action<Effect> OnEnded;

        private void Awake()
        {
            TryGetComponent(out _particleSystem);
            TryGetComponent(out _particleSystemRenderer);
        }

        private IEnumerator WaitToEffectEnd()
        {
            while (_particleSystem.isPlaying)
            {
                yield return null;
            }
            OnEnded?.Invoke(this);
        }

        public void Init(Color color)
        {
            _particleSystemRenderer.material.color = color;
            
            gameObject.SetActive(true);
            
            _particleSystem.Play();
            StartCoroutine(WaitToEffectEnd());
        }
    }
}

