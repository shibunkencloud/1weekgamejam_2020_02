using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePlayer : MonoBehaviour
{

Vector3 MOVEX = new Vector3(0.6f, 0f, 0f); 
Vector3 MOVEY = new Vector3(0f, 0.6f, 0f); 
float step = 2f; 
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
		
		
        if (transform.position == target) {
			SetTargetPosition ();
		}
		Move();
	    }
        
    void SetTargetPosition(){

		GameObject obj = (GameObject)Resources.Load("downBrock");
 
		prevPos = target;
		
		if(this.transform.position.x != 4.2f){
 
		if (Input.GetKey (KeyCode.RightArrow)) {

			target = transform.position + MOVEX;

			int ran = UnityEngine.Random.Range(0,5);

			if(ran == 0){
			Instantiate(obj,new Vector3(-1.2f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(obj,new Vector3(-0.6f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(obj,new Vector3(0.0f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(obj,new Vector3(0.6f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(obj,new Vector3(1.2f,4.2f,0.0f),Quaternion.identity);
			}

			return;
		}
		}

		if(this.transform.position.x != -4.2f){
		
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			target = transform.position - MOVEX;
			return;
		}
		}

		if(this.transform.position.y != 4.2f){
		if (Input.GetKey (KeyCode.UpArrow)) {
			target = transform.position + MOVEY;
			return;
		}
		}

		if(this.transform.position.y != -4.2f){
		if (Input.GetKey (KeyCode.DownArrow)) {
			target = transform.position - MOVEY;
			return;
		}
		}
	}
    void Move(){
		transform.position = Vector3.MoveTowards (transform.position, target, step * Time.deltaTime);
	}
}
