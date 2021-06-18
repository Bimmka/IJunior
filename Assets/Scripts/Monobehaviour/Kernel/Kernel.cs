using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelBuilder
{
    public class Kernel : MonoBehaviour
    {
        public void Init(float transformScale)
        {
            transform.localScale = new Vector3(1, transformScale, 1);
        }
    }
}

