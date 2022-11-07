using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WashingMachineTrigger : MonoBehaviour
{
    GameObject newTriggerObject;

    void OnCollisionEnter(Collision triggerObject)
    {
        Debug.Log("intersection");
        
    }
}
