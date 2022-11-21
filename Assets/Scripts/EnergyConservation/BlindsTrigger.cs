using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlindsTrigger : MonoBehaviour
{
    public GameObject canvas;
    private static bool isPlaying = false;
    private static int count = 4;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }
    public static int BlindCount()
    {
        return count;
    }
    public static void DecrementBlindCount()
    {
        --count;
    }

    public static bool IsPlaying()
    {
        if (count == 0)
        {
            return isPlaying = false;
        }
        else
        {
            return isPlaying;
        }
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            canvas.SetActive(true);
            isPlaying = true;
        }
    }

}
