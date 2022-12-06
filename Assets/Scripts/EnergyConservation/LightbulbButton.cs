using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightbulbButton : MonoBehaviour
{
    public GameObject canvas;
    public GameObject light;
    

    public void OnClick()
    {
        light.SetActive(true);
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
}
