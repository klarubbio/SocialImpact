using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void BeginGame()
    {
        canvas.SetActive(false);
        Time.timeScale = 1;
    }
}
