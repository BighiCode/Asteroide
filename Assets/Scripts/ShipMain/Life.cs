using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour
{

    public int life = 1;


    private void TakeDamage()
    {
        life -= 1;
        if (life > 0) return;
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Bullet"))
            TakeDamage();

    }
}
