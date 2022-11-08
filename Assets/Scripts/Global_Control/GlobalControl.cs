using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    // GLOBAL PARAMETERS
    private float water = 100f;
    private float air = 100f;
    private float forrest = 100f;

    // MINI-GAME SCORES
    private int deforestation = 0;
    private int waterConservation = 0;
    private int energyConservation = 0;

    void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else if(Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void saveParamaters(float w, float a, float f)
    {
        Instance.water = w;
        Instance.air = a;
        Instance.forrest = f;
    }

    public float getWater()
    {
        return Instance.water;
    }
    public float getAir()
    {
        return Instance.air;
    }
    public float getForrest()
    {
        return Instance.forrest;
    }

    public void setDeforestationScore(int score)
    {
        Instance.deforestation = score;
    }
    public int getDeforestaionScore()
    {
        return Instance.deforestation;
    }

    public void setWaterConservationScore(int score)
    {
        Instance.waterConservation = score;
    }
    public int getWaterConservationScore()
    {
        return Instance.waterConservation;
    }

    public void setEnergyConservationScore(int score)
    {
        Instance.energyConservation = score;
    }
    public int getEnergyConservation()
    {
        return Instance.energyConservation;
    }
}
