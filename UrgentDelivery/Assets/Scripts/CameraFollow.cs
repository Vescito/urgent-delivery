using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    public CinemachineFreeLook cam;
    public Transform player;

    void Start()
    {
    }

    void Update()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Car").transform;
            cam.Follow = player;
            cam.LookAt = player;
        }
    }
}
