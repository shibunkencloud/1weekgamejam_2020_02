using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class movePlayer : MonoBehaviour
{

public static int count;

Vector3 MOVEX = new Vector3(0.6f, 0f, 0f); 
Vector3 MOVEY = new Vector3(0f, 0.6f, 0f); 
float step = 2f; 
Vector3 target;      
Vector3 prevPos;   
public GameObject player;
public Text cleartext;



    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
		count = 0;
		
    }

    // Update is called once per frame
    void Update()
    {
		
        if (transform.position == target) {
			SetTargetPosition ();
		}
		Move();
		
		if(count >= 4){
			clear();
		}
	}
        
    void SetTargetPosition(){

		GameObject obj = (GameObject)Resources.Load("downBrock");
		GameObject lobj = (GameObject)Resources.Load("leftBrock");
 
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

			if(ran == 0){
			Instantiate(obj,new Vector3(-1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(obj,new Vector3(-2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(obj,new Vector3(-3.0f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(obj,new Vector3(1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(obj,new Vector3(2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 0){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}


			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,0.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,0f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,-4.2f,0.0f),Quaternion.identity);
			}
			
			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-0.6f,0.0f),Quaternion.identity);
			}

			return;
		}
		}

		if(this.transform.position.x != -4.2f){
		
		
		if (Input.GetKey (KeyCode.LeftArrow)) {
			target = transform.position - MOVEX;
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

			if(ran == 0){
			Instantiate(obj,new Vector3(-1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(obj,new Vector3(-2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(obj,new Vector3(-3.0f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(obj,new Vector3(1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(obj,new Vector3(2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 0){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}


			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,0.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,0f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,-4.2f,0.0f),Quaternion.identity);
			}
			
			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-0.6f,0.0f),Quaternion.identity);
			}
			return;
		}
		}

		if(this.transform.position.y != 4.2f){
		if (Input.GetKey (KeyCode.UpArrow)) {
			target = transform.position + MOVEY;
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

			if(ran == 0){
			Instantiate(obj,new Vector3(-1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(obj,new Vector3(-2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(obj,new Vector3(-3.0f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(obj,new Vector3(1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(obj,new Vector3(2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 0){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}


			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,0.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,0f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,-4.2f,0.0f),Quaternion.identity);
			}
			
			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-0.6f,0.0f),Quaternion.identity);
			}
			return;
		}
		}

		if(this.transform.position.y != -4.2f){
		if (Input.GetKey (KeyCode.DownArrow)) {
			target = transform.position - MOVEY;
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

			if(ran == 0){
			Instantiate(obj,new Vector3(-1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(obj,new Vector3(-2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(obj,new Vector3(-3.0f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(obj,new Vector3(1.8f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(obj,new Vector3(2.4f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 0){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}


			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,4.2f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,0.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,0f,0.0f),Quaternion.identity);
			}

			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-2.4f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-3.0f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-3.6f,0.0f),Quaternion.identity);
			}

			if(ran == 4){
			Instantiate(lobj,new Vector3(-4.2f,-4.2f,0.0f),Quaternion.identity);
			}
			
			if(ran == 1){
			Instantiate(lobj,new Vector3(-4.2f,-1.8f,0.0f),Quaternion.identity);
			}

			if(ran == 2){
			Instantiate(lobj,new Vector3(-4.2f,-1.2f,0.0f),Quaternion.identity);
			}

			if(ran == 3){
			Instantiate(lobj,new Vector3(-4.2f,-0.6f,0.0f),Quaternion.identity);
			}
			return;
		}
		}
	}

    void Move(){
		transform.position = Vector3.MoveTowards (transform.position, target, step * Time.deltaTime);
	}
	
	public static void addcount(int c){
		count += c;
	}

	public static int getcount(){
		return count;
	}

	void clear(){
		Destroy(player);
		cleartext.enabled = true;
		if(Input.GetMouseButtonDown(0)){
			//Application.LoadLevel("Title")
		}
	}


}
