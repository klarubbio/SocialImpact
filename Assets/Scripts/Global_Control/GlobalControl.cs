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
}
