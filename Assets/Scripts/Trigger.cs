using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }


    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("trigger");
        canvas.SetActive(true);
    }
}
