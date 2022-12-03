using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms;
using static System.Net.Mime.MediaTypeNames;
using Unity.VisualScripting;


public class LeaderboardDeforest : MonoBehaviour
{
    [SerializeField] GameObject display;
    public TMP_Text userScores;
    private WriteData data;
    public static bool hasClicked = false;


    public void Start()
    {
        display.SetActive(false);
        data = GameObject.Find("PLAYER_ACCOUNT").GetComponent<WriteData>();
    }
    public void Display()
    {
        //todo dont allow player to access leaderboard again when already clicked
        if (hasClicked)
        {
            display.SetActive(false);
            Time.timeScale = 1;
            userScores.text = "";
            hasClicked = false;
            return;
        }
        hasClicked = true;
        Time.timeScale = 0;
        display.SetActive(true);

        List<string[]> alldata = data.GetAllData();
        //int score;

        // Debug.Log(alldata.Count);
        var itemMoved = false;
        do
        {
            itemMoved = false;
            for (int i = 1; i < alldata.Count - 1; i++)
            {
                if (int.Parse(alldata[i][4]) < int.Parse(alldata[i + 1][4]))
                {
                    string[] higherArray = alldata[i + 1];
                    alldata[i + 1] = alldata[i];
                    alldata[i] = higherArray;
                    itemMoved = true;
                }
            }

        } while (itemMoved);
        int count = 0;
        for (int i = 1; i < alldata.Count; i++)
        {
            ++count;
            userScores.text += i + ". " + alldata[i][0] + ": " + alldata[i][4] + "\n";
            if (count == 10)
            {
                break;
            }
        }
    }
}
