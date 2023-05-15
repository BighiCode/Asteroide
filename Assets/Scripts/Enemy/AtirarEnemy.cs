using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEnemy : MonoBehaviour
{
    public Transform bulletSpawPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1;

    public int AsteroidSpawnDelay = 5;
    public float clock;

    // Update is called once per frame
    void Update()
    {

        clock += Time.deltaTime;
        if (clock <= AsteroidSpawnDelay) return;
        Instantiate(bulletPrefab, bulletSpawPoint.position, bulletSpawPoint.rotation);
        clock = 0;

    }
}
