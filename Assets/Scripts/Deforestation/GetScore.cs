using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetScore : MonoBehaviour
{
    public TMP_Text score;
    

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ScoreManager.GetScore();
        Player_Account.Instance.setDeforestationScore(ScoreManager.GetScore());
    }

}
