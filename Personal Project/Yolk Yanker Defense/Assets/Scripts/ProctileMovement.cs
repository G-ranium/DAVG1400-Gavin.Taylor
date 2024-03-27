using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProctileMovement : MonoBehaviour
{
    public float boundY = 20f;
    public float boundX = 20f;
    private float moveSpeed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (transform.position.y > boundY | transform.position.y < -boundY)
        {
            Destroy(gameObject);
        }
        if (transform.position.x > boundX | transform.position.x < -boundX)
        {
            Destroy(gameObject);
        }
    }
}
