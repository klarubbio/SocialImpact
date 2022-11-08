using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RightChoiceButton : MonoBehaviour
{
    [SerializeField]
    private GameObject exitButton;
    public TMP_Text exitText;
    
    

    public void OnItemSelected()
    {
        Debug.Log("correct");
        exitText.text = "Correct! Using the cold setting on your washing machine conserves energy and water.";
        exitButton.SetActive(true);
        exitText.enabled = true;
    }
}
