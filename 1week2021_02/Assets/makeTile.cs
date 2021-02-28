using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeTile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = (GameObject)Resources.Load("tile");
        Instantiate(obj,new Vector3(-3.0f,3.0f,-5.0f),Quaternion.identity);
        Instantiate(obj,new Vector3(3.0f,3.0f,-5.0f),Quaternion.identity);
        Instantiate(obj,new Vector3(3.0f,-3.0f,-5.0f),Quaternion.identity);
        Instantiate(obj,new Vector3(-3.0f,-3.0f,-5.0f),Quaternion.identity);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
