using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody enemyRb;
    public GameObject[] eggs;
    public int eggIndex;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        eggIndex = RandomEgg();
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(eggs[eggIndex].transform.position);
        Vector3 lookDirection = (eggs[eggIndex].transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * moveSpeed);
    }

    int RandomEgg()
    {
        int egg = Random.Range(0, 8);
        return egg;
    }
}
