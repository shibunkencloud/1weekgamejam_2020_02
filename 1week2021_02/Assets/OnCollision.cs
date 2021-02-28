using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter (Collision collision)
    {
        Debug.Log("col");
        if(collision.gameObject.name=="Sphere"){
            Destroy(gameObject);
            movePlayer.addcount(1);
        }
    }
}
