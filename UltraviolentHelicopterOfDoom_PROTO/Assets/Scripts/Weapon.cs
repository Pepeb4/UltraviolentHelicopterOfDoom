using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bulletPrefab;


    public float maxTime = 1;
    public float minTime = 0;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            Shoot();
            SetRandomTime();
        }

    }
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    void Shoot()
    {
        time = 0;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }


}
