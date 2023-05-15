using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Transform _transform;
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(transform.up * 10f, ForceMode2D.Impulse);
    }

    private void LateUpdate()
    {
        _rb.velocity = _rb.velocity.normalized * 10;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Enemy")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
