using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public Transform bulletSpawPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 40;

    public float AsteroidSpawnDelay = 0.2f;
    public float clock;
    // Update is called once per frame
    void Update()
    {
        clock += Time.deltaTime;
        if (clock <= AsteroidSpawnDelay) return;
        if (Input.GetKey(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawPoint.position, bulletSpawPoint.rotation);
            clock = 0;
        }
    }
}
