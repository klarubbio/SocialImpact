using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OkButton : MonoBehaviour
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
}
