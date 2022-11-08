using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WrongChoiceButton : MonoBehaviour
{

    [SerializeField]
    private GameObject exitButton;
    public TMP_Text exitText;
    

    public void OnItemSelected()
    {
        Debug.Log("Wrong Button Clicked");
        exitText.enabled = true;
        exitText.text = "Incorrect. Pick the setting that conserves energy and water.";

    }
}
