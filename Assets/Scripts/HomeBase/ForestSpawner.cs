using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestSpawner : MonoBehaviour
{
    public GameObject tree;
    GlobalControl gc;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1");
        gc = GameObject.Find("GlobalControl").GetComponent<GlobalControl>();
        for(int i = 0; i < gc.getForrest()/5; i++)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(3f, 9f), Random.Range(-10.7f, -10.5f), Random.Range(-6f, 2f));
            Instantiate(tree, spawnPosition, Quaternion.identity);
        }
    }
}
