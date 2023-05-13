using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{
    float velocidade = 6;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + (velocidade * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - (velocidade * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - (velocidade * Time.deltaTime), transform.position.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + (velocidade * Time.deltaTime), transform.position.y);
        }

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);

        transform.up = direction;

    }
}
