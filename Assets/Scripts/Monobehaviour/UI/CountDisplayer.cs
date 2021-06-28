using TMPro;
using Tower;
using UnityEngine;

namespace UI
{
    public class CountDisplayer : MonoBehaviour
    {
        [SerializeField] private TMP_Text _countText;

        private void Awake()
        {
            TowerObserver.OnPipeCountChanged += DisplayCount;
            TowerObserver.OnGameFinished += DisplayWinText;
        }

        private void OnDestroy()
        {
            TowerObserver.OnPipeCountChanged -= DisplayCount;
            TowerObserver.OnGameFinished -= DisplayWinText;
        }

        private void DisplayCount(int count)
        {
            _countText.text = count.ToString();
        }

        private void DisplayWinText()
        {
            _countText.text = "You win!";
        }
    }
}

