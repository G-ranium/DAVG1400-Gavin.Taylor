using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public float boundX = 25f;
    public float boundZ = 45f;
    private float startDelay = 2f;
    private float spawnInterval = 2f;

    private int location;

    public bool increaseEnemies = false;

    private Vector3 spawnPos;

    public GameObject[] enemyPrefabs;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.score % 500 == 0 && gameManager.score != 0 && !increaseEnemies)
        {
            increaseEnemies = true;
            InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval + 5);
        }
        else if (gameManager.score % 500 != 0 && increaseEnemies)
        {
            increaseEnemies = false;
        }
    }

    void SpawnRandomEnemy()
    {

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        location = Random.Range(0, 4);
        if(location == 0)
                spawnPos = new Vector3(Random.Range(-boundX, boundX), 0f, boundX);
        else if(location == 1)
                spawnPos = new Vector3(Random.Range(-boundX, boundX), 0f, -boundX);
        else if(location == 2)
                spawnPos = new Vector3(boundZ, 0, Random.Range(-boundX, boundX));
        else if(location == 3)
                spawnPos = new Vector3(-boundZ, 0f, Random.Range(-boundX, boundX));
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }

}
