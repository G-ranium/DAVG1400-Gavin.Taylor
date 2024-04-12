using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float speed = 5.0f;
    private float xRange = 15.0f;
    public GameObject laser;
    public GameObject blaster;
    public Dictionary<string, int> inventory = new Dictionary<string, int>();
    // Start is called before the first frame update
    void Start()
    {
        inventory.Add("PowerUps", 0);
    }

    // Update is called once per frame
    void Update()
    {

        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * speed * horizontalInput * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser,blaster.transform.position,laser.transform.rotation);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Debug.Log("Powerup Collected");
            Destroy(other.gameObject);
            inventory["PowerUps"] += 1;
            print($"Number of powerups: {inventory["PowerUps"]}");
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
    
}
