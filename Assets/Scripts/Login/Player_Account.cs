using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Account : MonoBehaviour
{
    public static Player_Account Instance;

    private string username;

    private int gameScore;

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

    public void setAccount(string user)
    {
        username = user;
    }
    public string getUser()
    {
        return Instance.username;
    }

    public void setGameScore(int score)
    {
        Instance.gameScore = score;
    }
    public int getGameScore()
    {
        return Instance.gameScore;
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
