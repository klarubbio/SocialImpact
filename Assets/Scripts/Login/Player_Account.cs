using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_Account : MonoBehaviour
{
    public static Player_Account Instance;

    public string username;

    public string[] databaseAccount;

    public int gameScore = 0;

    // MINI-GAME SCORES
    public int waterConservation = 0;
    public int energyConservation = 0;
    public int deforestation = 0;

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

    public void createAccount(string user, string password)
    {
        Instance.username = user;
        Instance.GetComponent<WriteData>().WriteMyData(username, password);
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

    public bool verifyAccount(string uName)
    {
        string[] account = Instance.GetComponent<WriteData>().GetPlayerData(uName);

        if(account.Length > 0)
        {
            databaseAccount = account;
            return true;
        }
        return false;
    }

    public bool verifyPassword(string uPass)
    {
        if(uPass.Equals(databaseAccount[1]))
        {
            return true;
        }

        return false;
    }

    public void readData()
    {
        Instance.username = databaseAccount[0];
        Instance.waterConservation = Int32.Parse(databaseAccount[2]);
        Instance.energyConservation = Int32.Parse(databaseAccount[3]);
        Instance.deforestation = Int32.Parse(databaseAccount[4]);
    }
}
