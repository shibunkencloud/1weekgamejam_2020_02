using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaCollision : MonoBehaviour
{

    float step = 2f;
    Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 tmp = new Vector2(0.6f,0.4f);
        target = collision.gameObject.transform.position + tmp ;
        move();
        
    }

    private void move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, step * Time.deltaTime);
    }

   
}
