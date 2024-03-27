using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody enemyRb;
    public GameObject[] eggs;
    private GameObject player;
    public int eggIndex;
    public bool eggDestroyed = false;
    public float boundZ = 30f;
    public float boundX = 30f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        eggIndex = RandomEgg();
        player = GameObject.Find("Player");
        eggs = GameObject.FindGameObjectsWithTag("Egg");
    }

    // Update is called once per frame
    void Update()
    {
        switch (eggDestroyed)
        {
            case false:
            {
                transform.LookAt(eggs[eggIndex].transform.position);
                Vector3 lookDirection = (eggs[eggIndex].transform.position - transform.position).normalized;
                enemyRb.AddForce(lookDirection * moveSpeed);
                break;
            }
            case true:
            {
                Vector3 lookDirection = (player.transform.position - transform.position).normalized;
                enemyRb.AddForce(-lookDirection * moveSpeed);
                break;
            }
        }
        if (transform.position.z > boundZ | transform.position.z < -boundZ)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > boundX | transform.position.x < -boundX)
        {
            Destroy(gameObject);
        }
    }

    int RandomEgg()
    {
        int egg = Random.Range(0, 8);
        return egg;
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy egg
        if(eggDestroyed == false)
        {
            if (other.CompareTag("Egg"))
            {
                Destroy(other.gameObject);
                eggDestroyed = true;
            }
        }


        if (other.CompareTag("Projectile"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
