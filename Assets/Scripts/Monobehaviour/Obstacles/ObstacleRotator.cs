using DG.Tweening;
using UnityEngine;

namespace Obstacles
{

    public class ObstacleRotator : MonoBehaviour
    {
        [SerializeField] private float _animationTime;

        private void Start()
        {
            StartAnimation();
        }

        private void StartAnimation()
        {
            transform.DORotate(
                    new Vector3(0, 360, 0),
                    _animationTime,
                    RotateMode.FastBeyond360)
                .SetLoops(-1, LoopType.Yoyo)
                .SetEase(Ease.InOutSine);
        }
    }
}
