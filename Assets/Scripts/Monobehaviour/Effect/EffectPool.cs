using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Effects
{
    public class EffectPool : MonoBehaviour
    {
        [SerializeField] private int _startCount;
        [SerializeField] private Effect _destroyEffectPrefab;

        private Queue<Effect> _effects = new Queue<Effect>();

        private void Awake()
        {
            CreateEffects(_startCount);
        }

        private void CreateEffects(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _effects.Enqueue(CreateEffect());
            }
        }

        private Effect CreateEffect()
        {
            Effect effect = Instantiate(_destroyEffectPrefab, transform);
            effect.gameObject.SetActive(false);
            effect.OnEnded += AddEffect;
            return effect;
        }


        private void AddEffect(Effect effect)
        {
            _effects.Enqueue(effect);
            effect.gameObject.SetActive(false);
        }

        public Effect GetEffect()
        {
            return _effects.Count == 0 ? CreateEffect() : _effects.Dequeue();
        }
    }
}

