using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    private GameObject car;
    public Material mat;

    public void changeTexture()
    {
        car = GameObject.FindWithTag("CarColor");

        car.GetComponent<Renderer>().material = mat;
    }
}
