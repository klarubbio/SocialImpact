using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermostatButtons : MonoBehaviour
{
    public GameObject canvas;
    public GameObject buttonName;
    

    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
}
