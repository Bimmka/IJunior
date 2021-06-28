using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Tower;
using UnityEngine;

namespace UI
{
    public class CountDisplayer : MonoBehaviour
    {
        [SerializeField] private TMP_Text countText;

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
            countText.text = count.ToString();
        }

        private void DisplayWinText()
        {
            countText.text = "You win!";
        }
    }
}

