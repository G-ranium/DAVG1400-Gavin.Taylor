using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = new Vector3(Input.mousePosition.x,0,Input.mousePosition.y)/20;
        mousePos.z -= 24.5f;
        transform.position = mousePos;
    }
}
