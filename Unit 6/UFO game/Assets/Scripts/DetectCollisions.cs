using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ScoreManager scoreManager;
    public PlayerController playerInv;
    public int scoreToGive;
    private AudioSource enemyAudio;
    public AudioClip enemyDeath;
    public int enemyHealth;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        enemyAudio = GameObject.Find("Player").GetComponent<AudioSource>();
        playerInv = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    private void Update()
    {
        if(enemyHealth <= 0) // if health is below 0 destroy UFO
        {
            enemyAudio.PlayOneShot(enemyDeath);
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("SuperPowerUp") && other.CompareTag("Laser"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            enemyAudio.PlayOneShot(enemyDeath);
            scoreManager.IncreaseScore(scoreToGive);
            playerInv.inventory["SuperPowerUps"]++;
            playerInv.UpdatePowerUpText();
        }
        //subtract 1 health from enemy
        else if (other.CompareTag("Laser"))
        {
            enemyHealth -= 1;
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("SuperLaser"))
        {
            enemyHealth = 0;
        }
        
    }
    
}
