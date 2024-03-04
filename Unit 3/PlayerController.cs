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
    private bool isCrouching;

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




        //see if player is in the air or has jumped to make sure there are no double jumps
        
        if (Input.GetButtonDown("Jump") == true & controller.isGrounded == true)
        {
            isJumping = true;
        }
        else
        {
            isJumping = false;
        }

        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            isCrouching = false;
        }
        //store that in the moveDirection variable multiplied by the move speed

        if(isCrouching == true)
        {
            moveDirection.x += horizontalPos * (moveSpeed / 2);
            moveDirection.z += verticalPos * (moveSpeed / 2);
        }
        else
        {
            moveDirection.x += horizontalPos * moveSpeed;
            moveDirection.z += verticalPos * moveSpeed;
        }

        //if the spacebar is pressed, move the y vector up
        if (isJumping == true)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);
        
        moveDirection.x = 0;
        moveDirection.z = 0;

    }
}