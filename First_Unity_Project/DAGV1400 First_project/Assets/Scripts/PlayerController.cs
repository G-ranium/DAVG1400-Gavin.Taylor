using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //variables to control various velocities for movement
    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;

    //variables regarding movement position
    private CharacterController controller;
    private Vector3 moveDirection;
    private bool isJumping;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //get directional input
        float horizontalPos = Input.GetAxis("Horizontal");
        float verticalPos = Input.GetAxis("Vertical");

        //store that in the moveDirection variable multiplied by the move speed
        moveDirection.x += horizontalPos * moveSpeed;
        moveDirection.z += verticalPos * moveSpeed;

        //see if player is in the air or has jumped to make sure there are no double jumps
        
        if (Input.GetButtonDown("Jump") == true & controller.isGrounded == true)
        {
            isJumping = true;
        }
        /*
        else if(controller.isGrounded == true)
        {
            isJumping = false;
        }
        */
        else
        {
            isJumping = false;
        }
        
        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
        
        if (isJumping == true)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }
        
        
        moveDirection.x = 0;
        moveDirection.z = 0;

    }
}
