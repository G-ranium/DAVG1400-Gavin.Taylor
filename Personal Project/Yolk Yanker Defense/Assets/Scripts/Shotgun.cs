using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;

public class Shotgun : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Quaternion projectileOffset = new UnityEngine.Quaternion(1,1,1,3);
            UnityEngine.Quaternion minusProjectileOffset = new UnityEngine.Quaternion(1,1,1,-3);
            Instantiate(projectile, transform.position, (transform.rotation * projectile.transform.rotation * projectileOffset));
            Instantiate(projectile, transform.position, (transform.rotation * projectile.transform.rotation * minusProjectileOffset));
            Instantiate(projectile, transform.position, (transform.rotation * projectile.transform.rotation));
        }
    }
}
