using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Quaternion = System.Numerics.Quaternion;

public class Shotgun : MonoBehaviour
{
    public ParticleSystem muzzleFlash;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            muzzleFlash.Play();
            Instantiate(projectile, transform.position, (transform.rotation * projectile.transform.rotation));
            for (int i = 1; i < 5; i++)
            {
                Instantiate(projectile, transform.position, (transform.rotation * projectile.transform.rotation * UnityEngine.Quaternion.Euler(Vector3.up * i)));
            }
            for (int i = 1; i < 5; i++)
            {
                Instantiate(projectile, transform.position, (transform.rotation * projectile.transform.rotation * UnityEngine.Quaternion.Euler(Vector3.down * i)));
            }
        }

    }

}
