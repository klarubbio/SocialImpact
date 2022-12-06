using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkButton : MonoBehaviour
{
    public GameObject canvas;
    

    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
}
