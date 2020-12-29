using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyer : MonoBehaviour
{
    [Header("Вектор направления движения, при соприкосновении с игроком")]
    [SerializeField] private Vector3 _moveDirection;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.GetComponent<PlayerMovement>() != null)  StartCoroutine(MovePlayer(collision.collider.GetComponent<IPlayerMovement>()));
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.GetComponent<PlayerMovement>() != null) StopAllCoroutines();
    }

    private IEnumerator MovePlayer(IPlayerMovement playerMovementInterface)
    {
        while(true)
        {
            playerMovementInterface.MovePlayerOnDirection(_moveDirection);
            yield return null;
        }
    }
}
