using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float boundX = 25f;
    public float boundZ = 25f;
    private float startDelay = 2f;
    private float spawnInterval = 5f;
    public GameObject[] enemyPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-boundX,boundX), 0.5f,boundZ);
        int enemyIndex = Random.Range(0,enemyPrefabs.Length);
            
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
