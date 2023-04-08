using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public CinemachineImpulseSource cinemachineImpulseSource;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cinemachineImpulseSource.GenerateImpulse(Camera.main.transform.forward);
        }
    }
}
