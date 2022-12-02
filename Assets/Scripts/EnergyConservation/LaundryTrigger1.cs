using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaundryTrigger1 : MonoBehaviour
{
    public GameObject canvas;
    private bool hasEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !hasEntered && !BlindsTrigger.IsPlaying() && !TurnOffLightsTrigger.IsPlaying())
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
            Debug.Log("Collide");
            hasEntered = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
