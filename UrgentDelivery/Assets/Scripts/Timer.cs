using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float timeRemaining;
    public TMP_Text timeDisplay;


    void Update()
    {
        if(timeRemaining >= 0) {
        timeRemaining -= Time.deltaTime; }
        else {
            timeRemaining = 0;
        }
        timeDisplay.text = ((int)timeRemaining).ToString();
    }
}
