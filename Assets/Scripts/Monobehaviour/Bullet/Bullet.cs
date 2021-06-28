using System;
using System.Collections;
using System.Collections.Generic;
using Obstacles;
using Tower;
using UnityEngine;

namespace Bullets
{
    [RequireComponent(typeof(Rigidbody))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _explosionForce;
        [SerializeField] private float _explosionRadius;
        [SerializeField] private float _returnTime;

        public event Action<Bullet> OnReturned;
        
        private Rigidbody _rigidbody;

        private Vector3 _moveDirection = Vector3.forward;
        private void Awake()
        {
            TryGetComponent(out _rigidbody);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out Pipe pipe))
            {
                ReturnToPool();
                pipe.Break();
            }
            else if (other.GetComponent<Obstacle>() != null)
            {
                Bounce();
                AddExplosionForce();
                StartCoroutine(WaitReturnToPool());
            }
               
                
        }

        private void AddExplosionForce()
        {
            _rigidbody.isKinematic = false;
            _rigidbody.AddExplosionForce(_explosionForce, transform.position + new Vector3(0,-1,1), _explosionRadius);
        }

        private void Bounce()
        {
            _moveDirection = Vector3.back + Vector3.up;
        }

        private void ReturnToPool()
        {
            _rigidbody.isKinematic = true;
            OnReturned?.Invoke(this);
            StopAllCoroutines();
        }

        private IEnumerator WaitReturnToPool()
        {
            yield return new WaitForSeconds(_returnTime);
            ReturnToPool();
        }

        private IEnumerator MoveOnDirection()
        {
            _moveDirection = Vector3.forward;
            while (true)
            {
               transform.Translate(_moveDirection * _speed * Time.deltaTime);
               yield return null;
            }
        }

        public void Move()
        {
            StartCoroutine(MoveOnDirection());
        }
    }
}

