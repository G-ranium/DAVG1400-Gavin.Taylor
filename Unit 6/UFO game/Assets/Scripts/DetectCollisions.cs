using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //destroy both laser and UFO when they collide
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
