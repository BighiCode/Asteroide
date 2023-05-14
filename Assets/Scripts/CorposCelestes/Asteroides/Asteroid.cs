using System;
using CorposCelestes.Asteroides;
using UnityEngine;
using Random = UnityEngine.Random;

public class Asteroid : MonoBehaviour
{
    private AsteroidStatus Status;
    private float lifeTime = 50; 
    private float clock; 

    public Asteroid(AsteroidStatus status)
    {
        Status = status; 
    }

    private void Start()
    {
        //GetComponent<ConstantForce2D>().force = new Vector2(0, 0);  
    }

    private void Update()
    {
        // clock += Time.deltaTime;
        // if (clock > lifeTime)
        //     Destroy(); 
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
