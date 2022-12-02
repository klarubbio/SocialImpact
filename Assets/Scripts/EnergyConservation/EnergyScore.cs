using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyScore : MonoBehaviour
{
    public static EnergyScore Instance;

    private int enegyGameScore = 0;

    private int lightOff = 0; // Max = 20
    private int openBlinds = 0; // Max = 20
    private int turnTVOff = 0; // Max = 10
    private int setThermostat = 0; // Max = 15
    private int replaceBulb = 0; // Max = 15
    private int doLaundry = 0; // Max = 20

    private int taskCount = 6;

    private bool laundryTemp = false;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    // TURN OFF LIGHTS
    public void turnOffLight(int points)
    {
        if(Instance.lightOff < 20)
        {
            Instance.lightOff += points;
        }
    }

    // OPEN BLINDS
    public void openBlindsScore(int points)
    {
        if(Instance.openBlinds < 20)
        {
            Instance.openBlinds += points;
        }
    }

    // TURN OFF TV
    public void tvOff()
    {
        Instance.turnTVOff = 10;
    }
    // SET THERMOSTSAT
    public void setThermoLow()
    {
        Instance.setThermostat = 5;
    }

    public void setThermoMid()
    {
        Instance.setThermostat = 10;
    }

    public void setThermoRight()
    {
        Instance.setThermostat = 15;
    }

    // REPLACE LIGHT BULB
    public void replaceLightCfl()
    {
        Instance.replaceBulb = 5;
    }

    public void replaceLightLED()
    {
        Instance.replaceBulb = 15;
    }

    // LAUNDRY TASK SCORE
    public void setLaudryHot()
    {
        if(!laundryTemp)
        {
            Instance.laundryTemp = true;
        }
    }

    public void setLaudryWarm()
    {
        if(!laundryTemp)
        {
            Instance.laundryTemp = true;
            Instance.doLaundry += 5;
        }
    }

    public void setLaudryCold()
    {
        if(!laundryTemp)
        {
            Instance.laundryTemp = true;
            Instance.doLaundry += 10;
        }
    }

    public void setLaundryLoadFull()
    {
        Instance.doLaundry += 10;
    }

    public void completeTask()
    {
        Instance.taskCount --;
        Debug.Log("Tasks Remaining" + taskCount);
        if(taskCount == 0)
        {
            Instance.calculateTotalScore();
        }
    }

    public void calculateTotalScore()
    {
        Instance.enegyGameScore += Instance.lightOff;
        Instance.enegyGameScore += Instance.openBlinds;
        Instance.enegyGameScore += Instance.turnTVOff;
        Instance.enegyGameScore += Instance.setThermostat;
        Instance.enegyGameScore += Instance.replaceBulb;
        Instance.enegyGameScore += Instance.doLaundry;
    }

    public int getTaskCount()
    {
        return Instance.taskCount;
    }

    public int getEnergyScore()
    {
        return Instance.enegyGameScore;
    }
}
