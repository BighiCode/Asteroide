using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirar : MonoBehaviour
{
    public Transform bulletSpawPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawPoint.position, bulletSpawPoint.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = bulletSpawPoint.up * bulletSpeed;
        }
        
    }
}
