using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    double score;
    double startTime;
    double endTime;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    public void startQ(double sTime)
    {
        startTime = sTime;
    }

    public void endQ(double eTime)
    {
        endTime = eTime;
        score = score + (int)((100 * (15 - (endTime - startTime)))/15);
        Debug.Log(score);
    }
}
