using UnityEngine;

namespace Platforms
{
    public class Platform : MonoBehaviour
    {
        public void Init(Vector3 position, Quaternion rotation, Transform parent)
        {
            transform.position = position;
            transform.rotation =  rotation;
            transform.SetParent(parent);
        }
    }
}

