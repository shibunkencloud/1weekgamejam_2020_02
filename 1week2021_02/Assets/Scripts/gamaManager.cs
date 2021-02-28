using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamaManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject tile = (GameObject)Resources.Load("tile");

        Instantiate(tile, new Vector3(3.0f, 3.0f, -9.0f), Quaternion.identity);
        Instantiate(tile, new Vector3(-3.0f, 3.0f, -9.0f), Quaternion.identity);
        Instantiate(tile, new Vector3(-3.0f, -3.0f, -9.0f), Quaternion.identity);
        Instantiate(tile, new Vector3(3.0f, -3.0f, -9.0f), Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
