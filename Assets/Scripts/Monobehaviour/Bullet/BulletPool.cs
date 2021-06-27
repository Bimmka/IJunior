using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Bullets
{
    public class BulletPool : MonoBehaviour
    {
        [SerializeField] private Bullet _bulletPrefab;
        [SerializeField] private int _startCount;

        private Queue<Bullet> _bullets = new Queue<Bullet>();

        private void Awake()
        {
            CreateBullets(_startCount);
        }

        private void CreateBullets(int count)
        {
            for (int i = 0; i < _startCount; i++)
            {
                _bullets.Enqueue(CreateBullet());
            }
        }

        private Bullet CreateBullet()
        {
            Bullet spawnedBullet = Instantiate(_bulletPrefab, transform);
            spawnedBullet.gameObject.SetActive(false);
            spawnedBullet.OnReturned += AddBullet;
            return spawnedBullet;
        }

        private void AddBullet(Bullet bullet)
        {
            _bullets.Enqueue(bullet);
            bullet.gameObject.SetActive(false);
            bullet.transform.SetParent(transform);
        }

        public Bullet GetBullet()
        {
            return _bullets.Count > 0? _bullets.Dequeue() : CreateBullet();
        }
    }
}

