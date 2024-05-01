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
    { // difficulty gradually increases as score goes up with new repition every 500 points the player gets
        if (gameManager.score % 500 == 0 && gameManager.score != 0 && !increaseEnemies)
        {
            increaseEnemies = true;
            InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval + 5);
        } // if its too fast it will be impossible hence the 5 seconds extra, game will exponentially get difficult
        else if (gameManager.score % 500 != 0 && increaseEnemies)
        {
            increaseEnemies = false;
        } // this is to make sure that it doesn't invoke repeating constantly
    }

    void SpawnRandomEnemy()
    {
        // function is self explanatory, however enemy is randomly spawned in one of the four corners of the screen
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
        // the code allows for more enemies to be created and added to to the list as it is coded to accept any length of array
    }

}
