using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerController : MonoBehaviour
{
    public Vector3 horizontalInput;
    private float turnSpeed = 500f;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //uses input from WASD to rotate character
        horizontalInput.y = Input.GetAxis("Horizontal");
        //horizontalInput.y = Input.GetAxis("Mouse X") + Input.GetAxis("Mouse Y");
        transform.Rotate(horizontalInput * turnSpeed * Time.deltaTime);
        
    }
    
}
