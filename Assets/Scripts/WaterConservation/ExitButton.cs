using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public GameObject canvas;

    public void OnClick()
    {
        canvas.SetActive(false);
    }
}
