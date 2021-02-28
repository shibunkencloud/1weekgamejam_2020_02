﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveCharactor : MonoBehaviour
{
    SpriteRenderer MainSpriteRenderer;

    public Sprite UpSprite1;
    public Sprite UpSprite2;
    public Sprite DownSprite1;
    public Sprite DownSprite2;
    public Sprite LeftSprite1;
    public Sprite LeftSprite2;
    public Sprite RightSprite1;
    public Sprite RightSprite2;


    Vector3 MOVEX = new Vector3(0.6f, 0f, 0f);
    Vector3 MOVEY = new Vector3(0f, 0.6f, 0f);
    float step = 2f;
    Vector3 target;
    Vector3 prevPos;
    int vector= 0;
    bool flag = true;
    bool flag2 = true;

    leftBrock script;
    downBrock script2;
    Collider2D col2D;

    public bool gameOverFlag = false;

    // Start is called before the first frame update
    void Start()
    {
        gameOverFlag = false;
        target = transform.position;
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = DownSprite1;
        col2D = gameObject.GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == target)
        {
            SetTargetPosition();
            ChangeVector();
        }
        Move();
        checkAria();
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        switch (collision.gameObject.name)
        {
            case "leftBrock(Clone)":
                script = collision.GetComponent<leftBrock>();
                if(script.prevPos.x == transform.position.x)
                {
                    target = prevPos;
                    Move();
                }
                else
                {
                    Vector3 tmp = script.target;
                    tmp.x = tmp.x + 0.6f;
                    target.x = tmp.x;
                    Move();
                }
                break;
            case "downBrock(Clone)":
                script2 = collision.GetComponent<downBrock>();
                if (script2.prevPos.y == transform.position.y)
                {
                    target = prevPos;
                    Move();
                }
                else
                {
                    Vector3 tmp = script2.target;
                    tmp.y = tmp.y - 0.6f;
                    target.y = tmp.y;
                    Move();
                }
                break;
            case "Cube (2)":
                target = prevPos;
                Move();
                break;
        }


    }

    void SetTargetPosition()
    {

        GameObject obj = (GameObject)Resources.Load("downBrock");
        GameObject lobj = (GameObject)Resources.Load("leftBrock");
        GameObject robj = (GameObject)Resources.Load("rightBrock");
        GameObject uobj = (GameObject)Resources.Load("upBrock");

        prevPos = target;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            target = transform.position + MOVEX;

            int ran = UnityEngine.Random.Range(0, 13);

            //down

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(0.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(-3.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(3.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-3.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(-3.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(-3.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(4.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            //left



            if (ran == 0)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }


            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -0.6f, 0.0f), Quaternion.identity);
            }

            //up

            if (ran == 0)
            {
                Instantiate(uobj, new Vector3(-1.2f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(uobj, new Vector3(-0.6f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(uobj, new Vector3(0.0f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(uobj, new Vector3(0.6f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(uobj, new Vector3(1.2f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(uobj, new Vector3(-1.8f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(uobj, new Vector3(-2.4f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(uobj, new Vector3(-3.0f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(uobj, new Vector3(1.8f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(uobj, new Vector3(2.4f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(uobj, new Vector3(3.0f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(uobj, new Vector3(-3.0f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(uobj, new Vector3(-3.6f,-4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(uobj, new Vector3(-3.6f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(uobj, new Vector3(4.0f, -4.2f, 0.0f), Quaternion.identity);
            }

            flag = !flag;
            vector = 1;
            if (this.transform.position.x < 4.1f)
            {
                target = transform.position + MOVEX;
                return;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            int ran = UnityEngine.Random.Range(0, 5);

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(0.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(-3.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }


            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -0.6f, 0.0f), Quaternion.identity);
            }
            flag = !flag;
            vector = 3;
            if (this.transform.position.x > -4.1f)
            {
                target = transform.position - MOVEX;
                return;
            }
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            int ran = UnityEngine.Random.Range(0, 5);

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(0.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(-3.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }


            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -0.6f, 0.0f), Quaternion.identity);
            }
            flag = !flag;
            vector = 2;
            if (this.transform.position.y < 4.5f)
            {
                target = transform.position + MOVEY;
                return;
            }
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            int ran = UnityEngine.Random.Range(0, 5);

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(0.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(0.6f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(1.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(obj, new Vector3(-1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(obj, new Vector3(-2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(obj, new Vector3(-3.0f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(obj, new Vector3(1.8f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(obj, new Vector3(2.4f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 0)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }


            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, 1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, 0f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -2.4f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.0f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -3.6f, 0.0f), Quaternion.identity);
            }

            if (ran == 4)
            {
                Instantiate(lobj, new Vector3(-4.2f, -4.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 1)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.8f, 0.0f), Quaternion.identity);
            }

            if (ran == 2)
            {
                Instantiate(lobj, new Vector3(-4.2f, -1.2f, 0.0f), Quaternion.identity);
            }

            if (ran == 3)
            {
                Instantiate(lobj, new Vector3(-4.2f, -0.6f, 0.0f), Quaternion.identity);
            }
            flag = !flag;
            vector = 0;
            if (this.transform.position.y > -4.1f)
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

    void ChangeVector()
    {
        switch(vector)
        {
            case 0:
                if (flag)
                {
                    MainSpriteRenderer.sprite = DownSprite1;
                }
                else
                {
                    MainSpriteRenderer.sprite = DownSprite2;
                }
                break;
            case 1:
                if (flag)
                {
                    MainSpriteRenderer.sprite = RightSprite1;
                }
                else
                {
                    MainSpriteRenderer.sprite = RightSprite2;
                }
                break;
            case 2:
                if (flag)
                {
                    MainSpriteRenderer.sprite = UpSprite1;
                }
                else
                {
                    MainSpriteRenderer.sprite = UpSprite2;
                }
                break;

            case 3:
                if (flag)
                {
                    MainSpriteRenderer.sprite = LeftSprite1; 
                }
                else
                {
                    MainSpriteRenderer.sprite = LeftSprite2;
                }
                break;
        }
    }

    void checkAria()
    {
        if(transform.position.x > 4.2f || transform.position.x < -4.2f || transform.position.y > 4.2f || transform.position.y < -4.2f)
        {
            gameOverFlag = true;
        }
    }
}