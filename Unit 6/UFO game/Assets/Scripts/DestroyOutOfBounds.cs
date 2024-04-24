using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 30.0f;
    public float lowerBounds = -10.0f;
    public GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Time.timeScale = 1;//when game starts, time is set to 1 to play
    }
    // Update is called once per frame
    void Update()
    {
        //if anything is outside of the player's view, destroy
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds) // if UFO passes player, game ends
        {
            Time.timeScale = 0;
            gameManager.isGameOver = true;
            Destroy(gameObject);
        }
    }
}
