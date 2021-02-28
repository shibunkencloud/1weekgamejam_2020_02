using System.Collections;
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

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
        MainSpriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        MainSpriteRenderer.sprite = DownSprite1;
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
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Vector3 tmp = collision.gameObject.transform.position;
        Debug.Log(tmp);
        if(tmp.y + 0.4f == transform.position.y)
        {
            Debug.Log("t");
            Debug.Log(tmp);
            tmp.x = tmp.x + 0.6f;
            target.x = tmp.x;
        }
        

        Move();

    }

    void SetTargetPosition()
    {

        prevPos = target;
        if (Input.GetKey(KeyCode.RightArrow))
        {
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
            flag = !flag;
            vector = 0;
            if (this.transform.position.y > -3.7f)
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
}