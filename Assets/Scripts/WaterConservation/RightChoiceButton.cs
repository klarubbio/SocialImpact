using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RightChoiceButton : MonoBehaviour
{
    [SerializeField]
    private GameObject exitButton;
    public Scorekeeper s;
    public TMP_Text exitText;
    
    void Start()
    {
        s = GameObject.Find("watermaze").GetComponent<Scorekeeper>();
    }

    public void OnItemSelected()
    {
        Debug.Log("correct");
        exitText.text = "Correct!";
        exitButton.SetActive(true);
        exitText.enabled = true;
        s.endQ(Time.timeAsDouble);
        s.increment();
    }
}
