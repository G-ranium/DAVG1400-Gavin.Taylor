using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    public ScoreManager scoreManager;
    public int scoreToGive;

    private void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive);
        //destroy both laser and UFO when they collide
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
