using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Countdown : MonoBehaviour
{
    public float time = 3;
    public TMP_Text countdown;
    public GameObject mechanics;
    public GameObject ingameUI;
    void Start()
    {
        mechanics.SetActive(false);
        ingameUI.SetActive(false);
    }

    void Update()
    {
    
        if(time >= 1) {
        time -= Time.deltaTime; }
        else {
        time = 1;
        this.gameObject.SetActive(false);
        mechanics.SetActive(true);
        ingameUI.SetActive(true);
        countdown.enabled = false;
        }
        countdown.text = ((int)time).ToString();

    }
}
