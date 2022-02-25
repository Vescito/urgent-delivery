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
        timeRemaining -= Time.deltaTime;
        timeDisplay.text = ((int)timeRemaining).ToString();
    }
}
