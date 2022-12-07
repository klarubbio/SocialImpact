using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial_hb : MonoBehaviour
{

    public bool tutorialDone;
    public GameObject tutorial_1;
    public GameObject pT;
    public GameObject cT;


    // Start is called before the first frame update
    void Start()
    {
        tutorialDone = GlobalControl.Instance.getTutorial();
    }
    void Awake()
    {
        tutorialDone = GlobalControl.Instance.getTutorial();
        if(! tutorialDone)
        {
            tutorial_1.SetActive(false);
            pT.SetActive(true);
            cT.SetActive(true);
        }
    }

    public void completeTutorial()
    {
        GlobalControl.Instance.turnOffTutorial();
    }
}
