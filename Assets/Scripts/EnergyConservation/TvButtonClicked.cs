using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TvButtonClicked : MonoBehaviour
{
    public GameObject canvas;
    public GameObject buttonName;
    public GameObject screen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        if (buttonName.name == "OffButton")
        {
            screen.GetComponent<Renderer>().material.color = Color.black;
        }
        Time.timeScale = 1;
        canvas.SetActive(false);
    }

}
