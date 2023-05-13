using UnityEngine;

public abstract class Asteroid : MonoBehaviour
{
    public int Life {get; set;}
    public int Resistence {get; set;} 
    public int Size {get; set;} 

    public Asteroid(int life, int resistence, int size)
    {
        Life = life; 
        Resistence = resistence; 
        Size = size; 
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
