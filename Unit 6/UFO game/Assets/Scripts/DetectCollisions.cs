using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;
    private AudioSource enemyAudio;
    public AudioClip enemyDeath;
    public int enemyHealth;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
        enemyAudio = GameObject.Find("Player").GetComponent<AudioSource>();
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
        //subtract 1 health from enemy
        enemyHealth -= 1;
        Debug.Log($"Health: {enemyHealth}");
        Destroy(other.gameObject);
    }
}
