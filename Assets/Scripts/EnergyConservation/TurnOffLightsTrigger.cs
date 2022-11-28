using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffLightsTrigger : MonoBehaviour
{
    public GameObject canvas;
    private static bool isPlaying = false;
    private static int lightCount = 5;
    private bool hasEntered = false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !hasEntered)
        {
            hasEntered = true;
            isPlaying = true;
            canvas.SetActive(true);
            Time.timeScale = 0;

        }
    }
    public static bool IsPlaying()
    {
        if (lightCount == 0)
        {
            isPlaying = false;
        }
        return isPlaying;
    }
    public static void DecrementCount()
    {
        --lightCount;
    }
}
