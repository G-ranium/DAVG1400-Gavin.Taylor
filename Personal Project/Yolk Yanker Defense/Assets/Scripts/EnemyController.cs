using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyController : MonoBehaviour
{
    public GameManager gameManager;
    private Rigidbody enemyRb;
    public GameObject[] eggs;
    private GameObject player;

    private AudioSource enemyAudio;
    public AudioClip enemyDeath;

    public bool eggDestroyed = false;
    public bool isDead = false;

    public int eggIndex;
    public int scoreToAdd;

    private float boundZ = 50f;
    private float boundX = 30f;
    [SerializeField] private float moveSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        eggIndex = RandomEgg();
        player = GameObject.Find("Player");
        eggs = GameObject.FindGameObjectsWithTag("Egg");
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        enemyAudio = GameObject.Find("Player").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (eggs.Length > eggIndex)
        {
            switch (eggDestroyed)
            {
                case false:
                {
                    Quaternion lookRot = Quaternion.LookRotation(eggs[eggIndex].transform.position - transform.position);
                    transform.rotation = Quaternion.Euler(0, lookRot.eulerAngles.y, lookRot.eulerAngles.z);
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                    break;
                }
                case true:
                {
                    Quaternion lookRot = Quaternion.LookRotation(transform.position - player.transform.position);
                    transform.rotation = Quaternion.Euler(0, lookRot.eulerAngles.y, lookRot.eulerAngles.z);
                    transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
                    break;
                }
            }
        }
        else
        {
            eggIndex = RandomEgg();
        }

        if (transform.position.z > boundZ | transform.position.z < -boundZ)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > boundX | transform.position.x < -boundX)
        {
            Destroy(gameObject);
        }
        if (isDead)
        {
            Destroy(gameObject);
            gameManager.score += scoreToAdd;
            gameManager.UpdateGUI();
            enemyAudio.PlayOneShot(enemyDeath, 0.5f);
            isDead = false;
        }
    }

    int RandomEgg()
    {
        int egg = Random.Range(0, eggs.Length);
        return egg;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy egg
        if(eggDestroyed == false)
        {
            if (other.CompareTag("Egg"))
            {
                other.gameObject.SetActive(false);
                eggDestroyed = true;
                gameManager.eggs -= 1;
                gameManager.UpdateGUI();
            }
        }


        if (other.CompareTag("Projectile"))
        {
            //Destroy(gameObject);
            Destroy(other.gameObject);
            isDead = true;
        }
    }
}
