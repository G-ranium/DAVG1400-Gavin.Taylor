using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public Vector3 mousePos;
    public Vector3 worldPos;

    // Update is called once per frame
    void Update()
    {
        //get mouse position then convert it to game space and player will
        // point to where ever the mouse is pointing (script is used on an empty game object)
        mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane + 20;

        worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = worldPos;
    }
}
