using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //variables are pretty self explanatory, however note that
    //obstacleprefabs is an array to spawn 3 different types of obstacles
    public GameObject[] obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2f;
    private float repeatRate = 2f;
    private PlayerController playerControllerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        //start repeating the function and set variable for the player controller script
        InvokeRepeating("SpawnObstacles", startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnObstacles()
    {
        //if the game hasn't ended, obstacles will keep spawning, objects will spawn at random
        //from an array
        if (playerControllerScript.gameOver == false)
        {
            int obstacle = Random.Range(0, obstaclePrefabs.Length);
            Instantiate(obstaclePrefabs[obstacle], spawnPos, obstaclePrefabs[obstacle].transform.rotation);              
        }
      
    }
}
