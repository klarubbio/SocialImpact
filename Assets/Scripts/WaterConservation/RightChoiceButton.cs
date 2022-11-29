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
        exitText.text = "Correct!";
        exitButton.SetActive(true);
        exitText.enabled = true;
    }
}
