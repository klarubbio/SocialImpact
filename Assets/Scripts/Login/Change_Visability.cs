using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Change_Visability : MonoBehaviour
{
    public TMP_InputField input;
    public Toggle visChange;
    

    // Update is called once per frame
    void Update()
    {
        if(!visChange.isOn)
        {
            input.contentType = TMP_InputField.ContentType.Standard;
        }
        else
        {
            input.contentType = TMP_InputField.ContentType.Password;
        }
        input.ForceLabelUpdate();
    }
}
