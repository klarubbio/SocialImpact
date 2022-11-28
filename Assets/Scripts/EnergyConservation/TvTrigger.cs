using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TvTrigger : MonoBehaviour
{
    public GameObject canvas;
    private bool hasEntered = false;
   // public GameObject display;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player" && !hasEntered && !BlindsTrigger.IsPlaying() && !TurnOffLightsTrigger.IsPlaying())
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
            hasEntered = true;

        }
    }
}
