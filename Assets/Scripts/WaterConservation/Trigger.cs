using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    public GameObject canvas;
    public GameObject button;
    public TMP_Text text;
    private bool active = true;
    private MeshRenderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        Debug.Log(canvas.name);
        renderer = GetComponent<MeshRenderer>();
    }

    public void Enable()
    {
        active = true;
        renderer.enabled = true;
        //add glow
    }


    void OnTriggerEnter(Collider collider)
    {
        Debug.Log("triggered");
        if(Time.time > 2.0 && active) //prevent initial trigger bug
        {
            Debug.Log("trigger");
            canvas.SetActive(true);
            button.SetActive(false);
            text.enabled = false;
            renderer.enabled = false;
        }
        
    }
}
