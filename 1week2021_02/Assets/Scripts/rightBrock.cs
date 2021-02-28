using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class rightBrock : MonoBehaviour
{
    Vector3 MOVEX = new Vector3(0.6f, 0f, 0f); 
    Vector3 MOVEY = new Vector3(0f, 0.6f, 0f); 
    float step = 2f; 
    public Vector3 target;      
    public Vector3 prevPos;  
    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == target) {
			SetTargetPosition ();
		}
		Move();

        if (transform.position.x > 4.2f || transform.position.x < -4.2f || transform.position.y > 4.2f || transform.position.y < -4.2f)
        {
            Destroy(this.gameObject);
        }
    }


    void SetTargetPosition(){
        prevPos = target;
		if (Input.GetKey (KeyCode.DownArrow) || Input.GetKey (KeyCode.UpArrow) || Input.GetKey (KeyCode.LeftArrow) || Input.GetKey (KeyCode.RightArrow)) {
            target = transform.position - MOVEX;
			return;
		
		}
    }
    void Move(){
		transform.position = Vector3.MoveTowards (transform.position, target, step * Time.deltaTime);
	}
}
