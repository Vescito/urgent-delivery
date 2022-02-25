using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Waypoints : MonoBehaviour
{
    public Image img;
    public Transform target;
    public Camera cam;
    public TMP_Text distanceText;


    private void Update()
    {
        if(!(Vector3.Dot((target.position - transform.position), transform.forward) < 0)) {
            img.transform.position = cam.WorldToScreenPoint(target.position);

        }
        distanceText.text = ((int) Vector3.Distance(target.position, transform.position)).ToString() + "m";

    }
}
