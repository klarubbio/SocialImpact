using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Trigger : MonoBehaviour
{
    public GameObject canvas;
    public GameObject button;
    public Scorekeeper s;
    public TMP_Text text;
    private bool active = true;
    private MeshRenderer renderer;
    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        s = GameObject.Find("watermaze").GetComponent<Scorekeeper>();
        canvas.SetActive(false);
        Debug.Log(canvas.name);
        startTime = Time.time;
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
        if(Time.time > (startTime+2.0) && active) //prevent initial trigger bug
        {
            Debug.Log("trigger");
            canvas.SetActive(true);
            button.SetActive(false);
            text.enabled = false;
            renderer.enabled = false;

            s.startQ(Time.timeAsDouble);
        }
        
    }
}
