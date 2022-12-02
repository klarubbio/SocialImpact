using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaundryButton : MonoBehaviour
{
    public GameObject canvas;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnClick()
    {
        Time.timeScale = 1;
        canvas.SetActive(false);
    }
   

    // Update is called once per frame
}
