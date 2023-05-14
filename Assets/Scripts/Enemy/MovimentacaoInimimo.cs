using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovimentacaoInimimo : MonoBehaviour
{
    // Start is called before the first frame update


    public float speed = 2;
    public Transform Target;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Target.GameObject() != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, Target.position, speed * Time.deltaTime);
            Vector2 direction = new Vector2(Target.position.x - transform.position.x, Target.position.y - transform.position.y);

            transform.up = direction;
        }

    }
}
