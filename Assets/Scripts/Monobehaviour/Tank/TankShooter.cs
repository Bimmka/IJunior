using Bullets;
using UnityEngine;


namespace Tank
{
    [RequireComponent(typeof(TankAnimator))]
    public class TankShooter : MonoBehaviour
    {
        [SerializeField] private BulletPool _bulletPool;
        [SerializeField] private float _attackDelay;
        [SerializeField] private Transform _shootPoint;
        
        private TankAnimator _animator;

        private float _timeFromLastAttack;

        private void Awake()
        {
            TryGetComponent(out _animator);
        }

        private void Update()
        {
            _timeFromLastAttack -= Time.deltaTime;

            if (_timeFromLastAttack < 0 && Input.GetMouseButton(0))
            {
                Shoot();
                _animator.StartAnimation(_attackDelay);
                _timeFromLastAttack = _attackDelay;
            }
        }

        private void Shoot()
        {
            Bullet currentBullet = _bulletPool.GetBullet();
            currentBullet.transform.SetParent(_shootPoint);
            currentBullet.transform.localPosition = Vector3.zero;
            currentBullet.gameObject.SetActive(true);
            currentBullet.Move();
        }
    }
}

