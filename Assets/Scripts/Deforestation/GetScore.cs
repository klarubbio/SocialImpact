using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetScore : MonoBehaviour
{
    public TMP_Text score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + ScoreManager.GetScore();
    }

}
