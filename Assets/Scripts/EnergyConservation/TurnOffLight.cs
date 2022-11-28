using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLight : MonoBehaviour
{
    public GameObject light;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !BlindsTrigger.IsPlaying() && TurnOffLightsTrigger.IsPlaying())
        {
            light.SetActive(false);
            TurnOffLightsTrigger.DecrementCount();
        }
    }
}
