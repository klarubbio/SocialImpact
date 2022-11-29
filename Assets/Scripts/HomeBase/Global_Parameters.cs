using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Parameters : MonoBehaviour
{
    private float WATER;
    private float maxWATER = 100f;
    public Parameter_Bar waterBar;
    
    private float AIR;
    private float maxAIR = 100f;
    public Parameter_Bar airBar;

    private float FORREST;
    private float maxFORREST = 100f;
    public Parameter_Bar forrestBar;


    public void Start()
    {
        if(GlobalControl.Instance != null)
        {
            WATER = GlobalControl.Instance.getWater();
            AIR = GlobalControl.Instance.getAir();
            FORREST = GlobalControl.Instance.getForrest();
        }

        if(waterBar != null)
        {
            waterBar.setParameter(WATER);
            waterBar.setMax(maxWATER);
        }

        if(airBar != null)
        {
            airBar.setParameter(WATER);
            airBar.setMax(maxAIR);
        }

        if(forrestBar != null)
        {
            forrestBar.setParameter(WATER);
            forrestBar.setMax(maxFORREST);
        }
    }

     public void Update()
     {
        //REMOVE - FOR TESTING ONLY
        if (Input.GetMouseButtonDown(1))
        { // if right button pressed...
            WATER -= 10;
        }

        if(waterBar != null)
        {
            waterBar.setParameter(WATER);
        }

        if(airBar != null)
        {
            airBar.setParameter(AIR);
        }

        if(forrestBar != null)
        {
            forrestBar.setParameter(FORREST);
        }

        GlobalControl.Instance.saveParamaters(WATER, AIR, FORREST);
     }
}
