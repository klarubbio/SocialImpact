using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    public GameObject canvas;
    public GameObject button;
    public TMP_Text text;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        Debug.Log(canvas.name);
    }


    void OnTriggerEnter(Collider collider)
    {
        if(Time.time > 2.0) //prevent initial trigger bug
        {
            Debug.Log("trigger");
            canvas.SetActive(true);
            button.SetActive(false);
            text.enabled = false;
        }
        
    }
}
