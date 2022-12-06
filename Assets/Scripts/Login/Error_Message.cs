using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Error_Message : MonoBehaviour
{   
    public GameObject background;
    public GameObject message_1;
    public GameObject message_2;
    public GameObject message_3;
    public GameObject message_4;

    private bool display = false;
    private bool m1 = false;
    private bool m2 = false;
    private bool m3 = false;
    private bool m4 = false;

    void Update()
    {
        if(display)
        {
            background.SetActive(true);
            if(m1)
            {
                message_1.SetActive(true);
            }
            else if(m2)
            {
                message_2.SetActive(true);
            }
            else if(m3)
            {
                message_3.SetActive(true);
            }
            else if(m4)
            {
                message_4.SetActive(true);
            }
        }
        else
        {
            m1 = false;
            m2 = false;
            m3 = false;
            background.SetActive(false);
            message_1.SetActive(false);
            message_2.SetActive(false);
            message_3.SetActive(false);
            message_4.SetActive(false);
        }
    }

    public void dispayMessage(int error)
    {
        display = true;
        if(error == 0)
        {
            m1 = true;
        }
        else if(error == 1)
        {
            m2 = true;
        }
        else if(error == 2)
        {
            m3 = true;
        }
        else if(error == 3)
        {
            m4 = true;
        }
    }
    public void clearError()
    {
        display = false;
    }
}
