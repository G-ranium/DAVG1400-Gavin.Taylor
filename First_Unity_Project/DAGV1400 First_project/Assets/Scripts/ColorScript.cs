using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Color is red");
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("Color is red");
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("Color is blue");
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Debug.Log("Color is blue");
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("Color is green");
        }
    }
}
