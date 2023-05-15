using System;
using System.Drawing;
using CorposCelestes.Asteroides;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Asteroid : MonoBehaviour
{
    public AsteroidStatus Status;
    public GameObject LowerAsteroid; 
    public Asteroid(AsteroidStatus status)
    {
        Status = status; 
    }

    private void LateUpdate()
    {
        transform.localScale = new Vector2(Status.Size, Status.Size);
    }

    private void TakeDamage()
    {
        Status.Life -= 1;
        if(Status.Life > 0) return;
        
        if(Status.Size == 1 )
            Destroy(gameObject);

        for (int i = 0; i < Status.Size; i++)
        {
            var instance = Instantiate(LowerAsteroid, transform.localPosition, Quaternion.identity);
            instance.GetComponent<ConstantForce2D>().force = new Vector2(Random.Range(-0.5F,0.5F), 0);
            instance.GetComponent<ConstantForce2D>().relativeForce = new Vector2(Random.Range(-0.5F,0.5F), Random.Range(-0.5F,0.5F));
            instance.GetComponent<Asteroid>().Status.Size = Status.Size / 2;    
        }
        
        Destroy(gameObject);
    }
    
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
            TakeDamage();
    }
    
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
