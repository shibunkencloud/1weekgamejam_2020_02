using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hataki : MonoBehaviour
{
    public bool gameOverFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkAria();
    }

    void checkAria()
    {
        if (transform.position.x > 4.2f || transform.position.x < -4.2f || transform.position.y > 4.2f || transform.position.y < -4.2f)
        {
            gameOverFlag = true;
        }
    }
}
