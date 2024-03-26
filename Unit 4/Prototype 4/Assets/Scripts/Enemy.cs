using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 3.0f;

    private Rigidbody enemyRb;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10) {Destroy(gameObject);}
        // move in the direction of the player
        Vector3 lookDirection = (Player.transform.position - transform.position).normalized;
        
        enemyRb.AddForce(lookDirection * moveSpeed);
    }
}
