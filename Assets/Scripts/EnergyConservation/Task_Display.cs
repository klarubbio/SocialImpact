using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Task_Display : MonoBehaviour
{
    public TMP_Text uiText;
    public GameObject numObject;
    public GameObject uiElement;
    public bool isTask = false;
    public bool isLight = false;
    public bool isBlinds = false;

    // Update is called once per frame
    void Update()
    {
        if(isTask && !isLight && !isBlinds)
        {
            uiText.text = EnergyScore.Instance.getTaskCount().ToString();
        }
        else if(isLight && !isTask && !isBlinds)
        {
            int lCount = numObject.GetComponent<TurnOffLightsTrigger>().getLightCount();
            if(lCount == 0)
            {
                uiElement.SetActive(false);
            }
            uiText.text = lCount.ToString();
        }
        else if(isBlinds && !isLight && !isTask)
        {
            int bCount = numObject.GetComponent<BlindsTrigger>().getBlindCount();
            if(bCount == 0)
            {
                uiElement.SetActive(false);
            }
            uiText.text = bCount.ToString();
        }
    }
}
