using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //variables to control various velocities for movement
    private float moveSpeed = 5f;
    private float jumpForce = 5f;
    private float gravity = 9.81f;
    private float stamina;

    //variables regarding movement position
    private CharacterController controller;
    private Vector3 moveDirection;
    private Vector3 rotation;
    
    //booleans to track conditions in movement
    private bool isJumping;
    private bool isCrouching;
    private bool isSprinting;
    

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //get directional input
        rotation.y = Input.GetAxis("Mouse X") * 50f;
        //float horizontalPos = Input.GetAxis("Horizontal");
        //float verticalPos = Input.GetAxis("Vertical");
        //detect mouse movement and rotate character
        if (Input.GetAxis("Mouse X") != 0)
        {
            transform.Rotate(rotation);
        }

        //see if player is in the air or has jumped to make sure there are no double jumps
        if (Input.GetButtonDown("Jump") == true & controller.isGrounded == true)
        {
            if (isCrouching == true)
            {
                isJumping = false;
            }
            else
            {
                isJumping = true;
            }
        }
        else
        {
            isJumping = false;
        }

        //if left control is pressed, enter into crouch mode and reduce speed
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            isCrouching = true;
            controller.height = 1f;
        }
        //once key is released, speed is set to normal
        else if (Input.GetKeyUp(KeyCode.LeftControl))
        {
            isCrouching = false;
            controller.height = 2f;
        }
        //same with left shift for sprinting
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }

        //if the space bar is pressed, move the y vector up
        if (isJumping == true)
        {
            moveDirection.y = jumpForce;
            isJumping = false;
        }
        
        //set the speed of the player
        if (isCrouching == true)
        {
            moveSpeed = 2.5f;
        }
        else if (isSprinting == true)
        {
            moveSpeed = 10f;
        }
        else
        {
            moveSpeed = 5f;
        }
        
        //moveDirection.x += horizontalPos * moveSpeed;
        //moveDirection.z += verticalPos * moveSpeed;

        //this works for local transforms (other method relied on world xyz axis and this is the only one
        //I could get to work)
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection.x = (transform.TransformDirection(Vector3.left)).x * moveSpeed;
            moveDirection.z = (transform.TransformDirection(Vector3.left)).z * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection.x = (transform.TransformDirection(Vector3.right)).x * moveSpeed;
            moveDirection.z = (transform.TransformDirection(Vector3.right)).z * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            moveDirection.x = (transform.TransformDirection(Vector3.forward)).x * moveSpeed;
            moveDirection.z = (transform.TransformDirection(Vector3.forward)).z * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection.x = -(transform.TransformDirection(Vector3.forward)).x * moveSpeed;
            moveDirection.z = -(transform.TransformDirection(Vector3.forward)).z * moveSpeed;

        }        
        //make gravity have a constant force over time
        moveDirection.y -= gravity * Time.deltaTime;
        
        //move the player after all other variables are applied
        controller.Move(moveDirection * Time.deltaTime);
        //reset the speeds back to 0 so that theres no sliding around
        //drain stamina, currently doesn't work
        if (isSprinting == true)
        {
            stamina -= 1f;
        }
        //reset all move values
        moveDirection.x = 0;
        moveDirection.z = 0;

    }
    

}