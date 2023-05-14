using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtirarEnemy : MonoBehaviour
{
    public Transform bulletSpawPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawPoint.position, bulletSpawPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawPoint.up * bulletSpeed ;
        }

    }
}
