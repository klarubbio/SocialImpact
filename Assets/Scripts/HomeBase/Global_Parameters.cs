using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global_Parameters : MonoBehaviour
{
    private float WATER;
    private float WATER_RATIO;
    private float maxWATER = 100f;
    public Parameter_Bar waterBar;
    
    private float AIR;
    private float AIR_RATIO;
    private float maxAIR = 100f;
    public Parameter_Bar airBar;

    private float FORREST;
    private float FOREST_RATIO;
    private float maxFORREST = 100f;
    public Parameter_Bar forrestBar;

    public Player_Account pa;

    public void Start()
    {
        pa = GameObject.Find("PLAYER_ACCOUNT").GetComponent<Player_Account>();

        WATER_RATIO = (float)pa.getWaterConservationScore() / 100f;
        AIR_RATIO = (float)pa.getEnergyConservation() / 100f;
        FOREST_RATIO = (float)pa.getDeforestaionScore() / 100f;

        WATER = 75f;
        AIR = 75f;
        FORREST = 75f;
        float amt = 0;

        if(WATER_RATIO != 0)
        {
            amt = ((WATER_RATIO / .75f) - 1f) * 100f;
            WATER += amt;
            FORREST += amt / 2;
        }
            
        if (AIR_RATIO != 0)
        {
            amt = ((AIR_RATIO / .75f) - 1f) * 100f;
            AIR += amt;
            WATER += amt / 2;
        }
            
        if(FOREST_RATIO != 0)
        {
            amt = ((FOREST_RATIO / .75f) - 1f) * 100f;
            FORREST += amt;
            AIR += amt / 2;
        }
            
        if (waterBar != null)
        {
            waterBar.setParameter(WATER);
            waterBar.setMax(maxWATER);
        }

        if(airBar != null)
        {
            airBar.setParameter(AIR);
            airBar.setMax(maxAIR);
        }

        if(forrestBar != null)
        {
            forrestBar.setParameter(FORREST);
            forrestBar.setMax(maxFORREST);
        }

        if (GlobalControl.Instance != null)
        {
            Debug.Log("2");
            GlobalControl.Instance.saveParamaters(WATER, AIR, FORREST);
        }
    }
}
