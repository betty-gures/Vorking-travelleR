using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionPlayer : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Vector3 ResetPosition, ResetRotation;

    private void Start()
    {
        Invoke(nameof(ResetingPosition),5f);
    }
    
    void ResetingPosition()
    {
        Player.transform.position = ResetPosition;
        Player.transform.rotation = new Quaternion(ResetRotation.x,ResetRotation.y,ResetRotation.z,1);
    }
}
