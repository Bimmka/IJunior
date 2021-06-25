using System.Linq;
using UnityEngine;

namespace Platforms
{
    public class Platform : MonoBehaviour
    {
        [SerializeField] private float _explosionForce;
        [SerializeField] private float _explosionRadius;

        private PlatformSegment[] _segments;
        
        public virtual void Init(Vector3 position, Quaternion rotation, Transform parent)
        {
            transform.position = position;
            transform.rotation =  rotation;
            transform.SetParent(parent);

            _segments = GetComponentsInChildren<PlatformSegment>().ToArray();
        }

        public void Break()
        {
            for (int i = 0; i < _segments.Length; i++)
            {
                _segments[i].Break(_explosionForce, transform.position, _explosionRadius);
            }
        }
    }
}

