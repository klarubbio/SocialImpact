using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] car;
    private float spawnX = 15;
    private float spawnZ = 20;
    private float startDelay = 2;
    private float timeInterval = 1.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, timeInterval);
        
    }
    void SpawnRandomCar()
    {
        int carIndex = Random.Range(0, car.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        Instantiate(car[carIndex], spawnPos, car[carIndex].transform.rotation);
    }
}
