using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //import public variables from playercontroller script
    private PlayerController playerControllerScript;
    //variables controlling movement of background and obstacles
    public float moveSpeed = 100f;
    private float leftBound = -15;
    // Start is called before the first frame update
    void Start()
    {
        //set the variable to the player so the program knows where to find the script
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        //if the game hasn't ended, the obstacles and background will keep going (uses variable from
        //the player controller script)
        if (playerControllerScript.gameOver == false)
        { 
            transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        //checks to see if the obstacles (and not the background) have gone out of bounds
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
        }

    }
}
