using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaundryButton : MonoBehaviour
{
    public GameObject canvas;
   
    
    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
   

    // Update is called once per frame
}
