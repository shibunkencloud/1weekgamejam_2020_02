using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharactor : MonoBehaviour
{

    Vector3 MOVEX = new Vector3(35f, 0f, 0f);
    Vector3 MOVEY = new Vector3(0f, 35f, 0f);
    float step = 90f;
    Vector3 target;
    Vector3 prevPos;


    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position == target)
        {
            SetTargetPosition();
        }
        Move();
    }

    void SetTargetPosition()
    {

        prevPos = target;

        if (this.transform.position.x != 4.2f)
        {

            if (Input.GetKey(KeyCode.RightArrow))
            {
                target = transform.position + MOVEX;
                return;
            }
        }

        if (this.transform.position.x != -4.2f)
        {


            if (Input.GetKey(KeyCode.LeftArrow))
            {
                target = transform.position - MOVEX;
                return;
            }
        }

        if (this.transform.position.y != 4.2f)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                target = transform.position + MOVEY;
                return;
            }
        }

        if (this.transform.position.y != -4.2f)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                target = transform.position - MOVEY;
                return;
            }
        }
    }
    void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, step * Time.deltaTime);
    }
}