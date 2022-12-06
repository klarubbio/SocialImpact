using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Player_Account : MonoBehaviour
{
    public static Player_Account Instance;

    private string username;
    private string password;

    private string[] databaseAccount;

    private int gameScore = 0;

    // MINI-GAME SCORES
    private int waterConservation = 0;
    private int energyConservation = 0;
    private int deforestation = 0;

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

    public void setWaterConservationScore(int score)
    {
        Instance.waterConservation = score;
        writeDatabase();
    }
    public int getWaterConservationScore()
    {
        return Instance.waterConservation;
    }

    public void setEnergyConservationScore(int score)
    {
        Instance.energyConservation = score;
        writeDatabase();
    }
    public int getEnergyConservation()
    {
        return Instance.energyConservation;
    }

    public void setDeforestationScore(int score)
    {
        Instance.deforestation = score;
        writeDatabase();
    }
    public int getDeforestaionScore()
    {
        return Instance.deforestation;
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
        Instance.password = databaseAccount[1];
        Instance.waterConservation = Int32.Parse(databaseAccount[2]);
        Instance.energyConservation = Int32.Parse(databaseAccount[3]);
        Instance.deforestation = Int32.Parse(databaseAccount[4]);
    }

    public void writeDatabase()
    {
        string wGame = Instance.waterConservation.ToString();
        string eGame = Instance.energyConservation.ToString();
        string dGame = Instance.deforestation.ToString();
        Instance.GetComponent<WriteData>().WriteMyData(username, password, wGame, eGame, dGame);
    }
}
