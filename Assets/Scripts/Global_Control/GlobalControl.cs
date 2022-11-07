using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalControl : MonoBehaviour
{
    public static GlobalControl Instance;

    public float water;
    public float air;
    public float forrest;

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
}
