using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBounds = 40.0f;
    public float lowerBounds = -10.0f;
    public float sideBounds = 17.0f;
    public GameManager gameManager;
    private AudioSource gameOverAudio;
    public AudioClip gameOver;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameOverAudio = GameObject.Find("Player").GetComponent<AudioSource>();
        Time.timeScale = 1;//when game starts, time is set to 1 to play
    }
    // Update is called once per frame
    void Update()
    {
        //if anything is outside of the player's view, destroy
        if(transform.position.x > sideBounds)
        {
            Destroy(gameObject);
        }
        if(transform.position.x < -sideBounds)
        {
            Destroy(gameObject);
        }
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBounds) // if UFO passes player, game ends
        {
            if(CompareTag("Enemy")) // Checks to see if its a UFO
            {
                gameOverAudio.PlayOneShot(gameOver, 1f);
                Time.timeScale = 0;
                gameManager.isGameOver = true;
                Destroy(gameObject);
            }
            else // Powerup will not trigger game over
            {
                Destroy(gameObject);
            }
        }
    }
}
