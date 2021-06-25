using System;
using Platforms;
using UnityEngine;

public class PlatformChecker : MonoBehaviour
{
    public static event Action OnLastPlatformReached;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlatformSegment>() != null)
            BreakPlatform(other.GetComponentInParent<Platform>());

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.GetComponentInParent<FinishPlatform>() != null)
            DisplayWinPanel();
    }

    private void BreakPlatform(Platform platform)
    {
        platform.Break();
    }

    private void DisplayWinPanel()
    {
        OnLastPlatformReached?.Invoke();
    }
}
