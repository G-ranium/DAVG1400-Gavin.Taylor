using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer = 2f;
    private bool timerOn = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) & timerOn == false)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timerOn = true;
        }

        if (timerOn == true)
        {
            if (timer < 0)
            {
                timer = 2f;
                timerOn = false;
            }
            else
            {
                timer -= 3 * Time.deltaTime;
            }
        }
    }
}
