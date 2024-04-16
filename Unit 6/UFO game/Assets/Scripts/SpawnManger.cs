using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] prefabs;

    private float spawnRange = 17f;

    private float spawnDelay = 2f;

    private float spawnFrequency = 1.5f;

    private int powerupCounter = 0;

    private int motherShipCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", spawnDelay,spawnFrequency);
    }

    void SpawnPrefab()
    {
        int prefabIndex;
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 1, 20);
        if (powerupCounter == 3)
        {
            prefabIndex = 0;
            powerupCounter = 0;
        }
        else if (motherShipCounter == 5)
        {
            prefabIndex = 3;
            motherShipCounter = 0;
        }
        else
        {
            prefabIndex = Random.Range(1, 3);
            powerupCounter++;
            motherShipCounter++;
        }
        Instantiate(prefabs[prefabIndex], spawnPos, prefabs[prefabIndex].transform.rotation);
    }
}
