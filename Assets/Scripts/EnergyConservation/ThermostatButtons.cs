using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermostatButtons : MonoBehaviour
{
    public GameObject canvas;
    public GameObject buttonName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
}
