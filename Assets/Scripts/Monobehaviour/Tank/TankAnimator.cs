using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Tank
{
    public class TankAnimator : MonoBehaviour
    {
        [SerializeField] private float _zAxisOffset = 0.5f;
        public void StartAnimation(float animationTime)
        {
            transform.DOMoveZ(transform.position.z - _zAxisOffset, animationTime / 2).
                SetLoops(2, LoopType.Yoyo).
                SetEase(Ease.InOutSine);
        }
    }
}

