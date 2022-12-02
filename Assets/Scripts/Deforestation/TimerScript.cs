using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class  TimerScript : MonoBehaviour
{
    public float timeLeft = 5;
    public static bool timerOn = true;
    public TMP_Text timerTxt;
    public GameObject canvas;

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                updateTimer(timeLeft);
            }
            else
            {
                Debug.Log("Time is up");
                timeLeft = 0;
                timerOn = false;
                canvas.SetActive(true);
                Time.timeScale = 0;
            }
        }
        
    }
    void updateTimer(float currentTime)
    {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);
        timerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        
    }
}
