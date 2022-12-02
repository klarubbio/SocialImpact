using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private static int score = 100;

    public static void DecrementScore()
    {
        Debug.Log(score);
        if (score <= 0)
        {
            score = 0;
            return;
        }
        score -= 5;
    }
    public static int GetScore()
    {
        return score;
    }
}
