using UnityEngine;

public class BulletShip : MonoBehaviour
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
        if (collision.gameObject.tag != "Player" && collision.gameObject.tag != "Bullet")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
