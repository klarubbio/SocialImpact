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
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger");
        canvas.SetActive(true);
        button.SetActive(false);
        text.enabled = false;
    }
}
