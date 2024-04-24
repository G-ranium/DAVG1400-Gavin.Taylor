using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManger : MonoBehaviour
{
    public GameObject[] prefabs;
    public GameObject powerUp;
    public GameObject superPowerUp;
    public PlayerController playerInv;

    private float spawnRange = 12f;
    private float spawnDelay = 2f;
    private float spawnFrequency = 1.5f;
    private int motherShipCounter;
    private int powerUpCounter;
    // Start is called before the first frame update
    void Start()
    {
        playerInv = GameObject.Find("Player").GetComponent<PlayerController>();
        //repeat spawning every 1.5 seconds
        InvokeRepeating("SpawnPrefab", spawnDelay,spawnFrequency);
        InvokeRepeating("PowerUpSpawner",spawnDelay,spawnFrequency);
        
    }

    void SpawnPrefab()
    {
        int prefabIndex;
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 1, 35);
        if (motherShipCounter == 1) //spawn a mothership when counter is 5
        {
            prefabIndex = 2;
            motherShipCounter = 0;
        }
        else //otherwise just spawn a scout or a normal UFO
        {
            prefabIndex = Random.Range(0, 2);
            motherShipCounter = Random.Range(0, 8);
        }
        Instantiate(prefabs[prefabIndex], spawnPos, prefabs[prefabIndex].transform.rotation);
    }

    void PowerUpSpawner()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 1, 35);
        Vector3 superSpawnPos = new Vector3(-15, 1, 20);
        powerUpCounter = Random.Range(0, 10);
        if (powerUpCounter < 3 && playerInv.inventory["PowerUps"] <= 5)
            Instantiate(powerUp, spawnPos, powerUp.transform.rotation);
        else if (powerUpCounter == 5 && playerInv.inventory["SuperPowerUps"] < 1)
            Instantiate(superPowerUp, superSpawnPos, superPowerUp.transform.rotation);
    }
}
