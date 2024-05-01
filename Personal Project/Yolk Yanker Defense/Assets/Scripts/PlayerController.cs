using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class PlayerController : MonoBehaviour
{
    public Vector3 horizontalInput;

    public ParticleSystem muzzleFlash;

    public AudioSource playerAudio;
    public AudioClip gunfire;

    public GameManager gameManager;
    public GameObject mousePos;
    public GameObject projectile;
    public GameObject projectileSpawner;
    // Start is called before the first frame update
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.isGameOver && !gameManager.isPaused)
        {
            transform.LookAt(mousePos.transform.position); //unless game is paused or over, player can rotate in circles
            if (Input.GetKeyDown(KeyCode.Mouse0)) // with above conditions if mouse is clicked, fire projectiles
            {
                muzzleFlash.Play();
                playerAudio.PlayOneShot(gunfire, 0.5f);
                Instantiate(projectile, projectileSpawner.transform.position, (projectileSpawner.transform.rotation * projectile.transform.rotation));
                for (int i = 1; i < 5; i++)
                {
                    Instantiate(projectile, projectileSpawner.transform.position, (projectileSpawner.transform.rotation * projectile.transform.rotation * UnityEngine.Quaternion.Euler(Vector3.up * i)));
                }
                for (int i = 1; i < 5; i++)
                {
                    Instantiate(projectile, projectileSpawner.transform.position, (projectileSpawner.transform.rotation * projectile.transform.rotation * UnityEngine.Quaternion.Euler(Vector3.down * i)));
                }
            } // one gunshot is fired in the center and the right and left fire various bullets
        }


    }
    
}
