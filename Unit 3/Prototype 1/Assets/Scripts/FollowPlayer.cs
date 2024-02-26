using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private Vector3 offset = new Vector3(0, 8, -13);
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //Follow the vehicle and trail behind by the small offset in the vector 3
        transform.position = player.transform.position + offset;
    }
}
