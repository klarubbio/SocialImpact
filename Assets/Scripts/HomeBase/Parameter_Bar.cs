using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parameter_Bar : MonoBehaviour
{
    public float MAX_PARAMETER = 100f;

    private float value;

    private Image parambar;

    public void setParameter(float input)
    {
        value = input;
    }
    public void setMax(float max)
    {
        MAX_PARAMETER = max;
    }

    void Start()
    {
        parambar = GetComponent<Image>();
    }

    void Update()
    {

        //TEMPORARY FOR TESTING
        parambar.fillAmount = value / MAX_PARAMETER;
    }



}
