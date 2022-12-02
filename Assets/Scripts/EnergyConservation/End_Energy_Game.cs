using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class End_Energy_Game : MonoBehaviour
{
    public TMP_Text scoreText;
    public GameObject endGame;
    public GameObject player;
    public GameObject gameUI;

    // Start is called before the first frame update
    void Start()
    {
        endGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(EnergyScore.Instance.getTaskCount() == 0)
        {
            player.SetActive(false);
            gameUI.SetActive(false);
            scoreText.text = EnergyScore.Instance.getEnergyScore().ToString();
            endGame.SetActive(true);
            Player_Account.Instance.setEnergyConservationScore(EnergyScore.Instance.getEnergyScore());
        }
    }
}
