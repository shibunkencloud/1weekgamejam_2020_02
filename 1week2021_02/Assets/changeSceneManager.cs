using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneManager : MonoBehaviour
{
    moveCharactor script;
    public GameObject chara;

    // Start is called before the first frame update
    void Start()
    {
        script = chara.GetComponent<moveCharactor>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(script.gameOverFlag);
        if (script.gameOverFlag)
        {
            ChageScene();
        }
    }

    void ChageScene()
    {
        SceneManager.LoadScene("GameOver");
    }
}
