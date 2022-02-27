using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject finishPanel;

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "Car")
        {
            finishPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

}
