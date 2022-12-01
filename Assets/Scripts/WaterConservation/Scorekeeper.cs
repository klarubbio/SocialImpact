using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{
    double score;
    double startTime;
    double endTime;

    int total;
    int found;

    public WriteData w;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        total = 2;//hardcoded to number of interactions possible
        found = 0;
    }

    void Update()
    {
        if(total == found)
        {
            Debug.Log("done");
            w.WriteMyData("someuser", "somepass", water:score.ToString());
            //prompt to go back to home
        }
    }

    public void increment()
    {
        found++;
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
