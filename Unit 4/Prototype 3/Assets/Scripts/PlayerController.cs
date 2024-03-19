using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variables containing sounds and animations
    private Animator playerAnim;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtSplatter;
    private AudioSource playerAudio;
    private Rigidbody playerRb;
    public AudioClip jumpSound;
    public AudioClip crashSound;
    
    // variables to control player movement
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        //allows player to jump, when they jump it plays an animation and a sound
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            dirtSplatter.Stop();
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        //detects collision with the ground, they are on the ground
        //it creates particles
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtSplatter.Play();
        }
        //if a player collides with an obstacle the game ends and it plays an animation
        //the player will then be constricted and unable to move
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerAudio.PlayOneShot(crashSound, 1.0f);
            dirtSplatter.Stop();
            gameOver = true;
            Debug.Log("Game Over!");
            explosionParticle.Play();
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
        }

    }
}
