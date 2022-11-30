using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leaderboard : MonoBehaviour
{
    [SerializeField] GameObject leaderboard;

    private void Start()
    {
        leaderboard.SetActive(false);
    }
    public void Display()
    {
        leaderboard.SetActive(true);
    }
}
