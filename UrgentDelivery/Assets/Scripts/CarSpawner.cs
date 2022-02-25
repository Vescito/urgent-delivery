using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject car;


    void Start()
    {
        Instantiate(car, spawnpoint);
    }

}
