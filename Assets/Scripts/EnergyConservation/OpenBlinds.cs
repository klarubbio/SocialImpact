using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBlinds : MonoBehaviour
{

   // BlindsTrigger blinds = new BlindsTrigger();
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && BlindsTrigger.IsPlaying() && !TurnOffLightsTrigger.IsPlaying())
        {
            BlindsTrigger.DecrementBlindCount();
            this.gameObject.SetActive(false);
        }
    }
}
