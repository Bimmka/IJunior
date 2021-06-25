using System;
using UnityEngine;

namespace LevelBuilder
{
    public class Kernel : MonoBehaviour
    {
        public static event Action<Kernel> OnSpawned; 
        public void Init(float transformScale)
        {
            transform.localScale = new Vector3(1, transformScale, 1);
            OnSpawned?.Invoke(this);
        }
    }
}

