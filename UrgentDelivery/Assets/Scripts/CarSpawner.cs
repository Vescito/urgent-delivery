using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CarSpawner : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject car;
    public CinemachineFreeLook cinecam;


    void Start()
    {
        Instantiate(car, spawnpoint);
        cinecam.m_YAxis.m_InputAxisName = "Mouse Y";
        cinecam.transform.position = new Vector3(0, 0, 0);
    }

}
