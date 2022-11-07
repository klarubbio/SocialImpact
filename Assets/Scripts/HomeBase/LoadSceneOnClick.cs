using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour
{
    public int sceneIndex = 0;
    
    public void LoadGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }
}
