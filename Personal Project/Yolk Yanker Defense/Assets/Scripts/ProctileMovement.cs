using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProctileMovement : MonoBehaviour
{
    public float boundZ = 20f;
    public float boundX = 20f;
    public float moveSpeed = 1f;

    // Update is called once per frame
    void Update()
    { // moves the projectile forward until it hits the edge of the map somewhere
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (transform.position.z > boundZ | transform.position.z < -boundZ)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > boundX | transform.position.x < -boundX)
        {
            Destroy(gameObject);
        }
    }
}
