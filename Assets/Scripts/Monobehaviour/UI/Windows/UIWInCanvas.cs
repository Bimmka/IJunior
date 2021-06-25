using UnityEngine;
using DG.Tweening;

namespace UI
{
    [RequireComponent(typeof(Canvas))]
    public class UIWInCanvas : MonoBehaviour
    {
        [SerializeField] private float _animationTime = 1.5f;
        [SerializeField] private RectTransform _background;
        
        private Canvas _canvas;

        private void Awake()
        {
            TryGetComponent(out _canvas);
            PlatformChecker.OnLastPlatformReached += Open;
            ChangeCanvasEnableState(false);
        }

        private void OnDestroy()
        {
            PlatformChecker.OnLastPlatformReached -= Open;
        }

        private void Open()
        {
            if (_canvas.enabled == false)
            {
                ChangeCanvasEnableState(true);
                StartAnimation();
            }
        }

        private void StartAnimation()
        {
            _background.DOLocalMove(Vector3.zero, _animationTime).SetEase(Ease.InOutSine);
        }

        private void ChangeCanvasEnableState(bool isEnable)
        {
            _canvas.enabled = isEnable;
        }
    }
}

