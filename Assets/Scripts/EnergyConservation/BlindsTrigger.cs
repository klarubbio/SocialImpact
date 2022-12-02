using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindsTrigger : MonoBehaviour
{
    public GameObject canvas;
    public GameObject uiBlind;
    private static bool isPlaying = false;
    private static int count = 4;
    private bool hasEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        uiBlind.SetActive(false);
    }

    public static int BlindCount()
    {
        return count;
    }
    public static void DecrementBlindCount()
    {
        --count;
        Debug.Log("Blinds Remaining: " + count);
        EnergyScore.Instance.openBlindsScore(5);
        if(count == 0)
        {
            EnergyScore.Instance.completeTask();
        }
    }

    public static bool IsPlaying()
    {
        if (count == 0)
        {
            return isPlaying = false;
        }
        else
        {
            return isPlaying;
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !TurnOffLightsTrigger.IsPlaying() && !hasEntered)
        {
            hasEntered = true;
            Time.timeScale = 0;
            canvas.SetActive(true);
            uiBlind.SetActive(true);
            isPlaying = true;
        }
    }

    public int getBlindCount()
    {
        return count;
    }

}
