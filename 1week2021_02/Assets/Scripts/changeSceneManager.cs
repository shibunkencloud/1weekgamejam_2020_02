using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneManager : MonoBehaviour
{
    moveCharactor script;
    public GameObject chara;

    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        script = chara.GetComponent<moveCharactor>();
    }

    // Update is called once per frame
    void Update()
    {

        if (script.gameOverFlag && count == 0)
        {
            count += 1;
            FadeManager.Instance.LoadScene("GameOver", 0.5f);
        }else if (script.gameClearFlag && count == 0)
        {
            count += 1;
            FadeManager.Instance.LoadScene("clear", 0.5f);
        }
    }

}
