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
    private int powerupCounter;
    private int motherShipCounter;
    // Start is called before the first frame update
    void Start()
    {
        //repeat spawning every 1.5 seconds
        InvokeRepeating("SpawnPrefab", spawnDelay,spawnFrequency);
    }

    void SpawnPrefab()
    {
        int prefabIndex;
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 1, 20);
        if (powerupCounter == 3) //spawn a powerup every 3 UFOs
        {
            prefabIndex = 0;
            powerupCounter = 0;
        }
        else if (motherShipCounter == 5) //spawn a mothership every 5 UFOs
        {
            prefabIndex = 3;
            motherShipCounter = 0;
        }
        else //otherwise just spawn a scout or a normal UFO
        {
            prefabIndex = Random.Range(1, 3);
            powerupCounter++;
            motherShipCounter++;
        }
        Instantiate(prefabs[prefabIndex], spawnPos, prefabs[prefabIndex].transform.rotation);
    }
}
