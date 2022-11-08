using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepositionPlayer : MonoBehaviour
{
    [SerializeField] private GameObject CameraRig, OculusRig;
    [SerializeField] private Vector3 ResetPositionCamera, ResetRotationCamera,ResetPositionRig, ResetRotationRig;

    private void Start()
    {
        Invoke(nameof(ResetingPosition),2f);
    }
    
    void ResetingPosition()
    {
        CameraRig.transform.position = ResetPositionCamera;
        CameraRig.transform.rotation = new Quaternion(ResetRotationCamera.x,ResetRotationCamera.y,ResetRotationCamera.z,1);
        
        OculusRig.transform.position = ResetPositionRig;
        OculusRig.transform.rotation = new Quaternion(ResetRotationRig.x,ResetRotationRig.y,ResetRotationRig.z,1);
    }
}
