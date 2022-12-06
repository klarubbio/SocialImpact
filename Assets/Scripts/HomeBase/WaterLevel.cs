using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterLevel : MonoBehaviour
{
    GlobalControl gc;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Activate", 1f);
    }

    void Activate()
    {
        gc = GameObject.Find("GlobalControl").GetComponent<GlobalControl>();
        transform.Translate(Vector3.back * gc.getWater() / 50);
    }
}
