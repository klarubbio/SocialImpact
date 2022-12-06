using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scorekeeper : MonoBehaviour
{
    double score;
    double startTime;
    double endTime;

    int total;
    int found;

    public WriteData w;
    Player_Account pa;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        total = 5;//hardcoded to number of interactions possible
        found = 0;

        pa = GameObject.Find("PLAYER_ACCOUNT").GetComponent<Player_Account>();
    }

    void Update()
    {
        if(total == found)
        {
            Debug.Log("done");
            pa.setWaterConservationScore((int)score);
            //prompt to go back to home
            SceneManager.LoadScene(1);
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
        score = score + (int)((20 * (15 - (endTime - startTime)))/15);
        Debug.Log(score);
    }
}
