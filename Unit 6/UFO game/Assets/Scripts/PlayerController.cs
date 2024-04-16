using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private float xRange = 15.0f;

    public GameObject laser;
    public GameObject blaster;
    public GameObject rightBlaster;
    public GameObject leftBlaster;
    public GameObject powerupIndicator;

    public Dictionary<string, int> inventory = new Dictionary<string, int>();

    private bool powerupOn = false;
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

        if (Input.GetKeyDown(KeyCode.S) && !powerupOn)
        {
            if (inventory["PowerUps"] > 0)
            {
                powerupIndicator.SetActive(true);
                powerupOn = true;
                inventory["PowerUps"]--;
                StartCoroutine(PowerupTimer());
            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laser,blaster.transform.position,laser.transform.rotation);
            if (powerupOn)
            {
                Instantiate(laser,rightBlaster.transform.position,rightBlaster.transform.rotation);
                Instantiate(laser,leftBlaster.transform.position,leftBlaster.transform.rotation);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            Debug.Log("Powerup Collected");
            Destroy(other.gameObject);
            inventory["PowerUps"]++;
            print($"Number of powerups: {inventory["PowerUps"]}");
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
    
    IEnumerator PowerupTimer()
    {
        WaitForSeconds timer = new WaitForSeconds(5);
        yield return timer;
        powerupIndicator.SetActive(false);
        powerupOn = false;
    }
    
}
