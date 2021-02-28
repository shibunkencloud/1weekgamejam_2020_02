using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeSceneManager : MonoBehaviour
{
    moveCharactor script;
    hataki script2;
    public GameObject chara;
    private
    int count;

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        script = chara.GetComponent<moveCharactor>();
        //script2 = hataki.GetComponent<hataki>();
    }

    // Update is called once per frame
    void Update()
    {

        if (script.hataki)
        {
            GameObject hataki = GameObject.Find("hataki(Clone)");
            script2 = hataki.GetComponent<hataki>();
        }
        
        if (script.gameOverFlag && count == 0)
        {
            count += 1;
            FadeManager.Instance.LoadScene("GameOver", 0.5f);
        }
        if(script2.gameOverFlag && count == 0)
        {
            count += 1;
            FadeManager.Instance.LoadScene("GameOver", 0.5f);
        }
        if (script.gameClearFlag && count == 0)
        {
            count += 1;
            FadeManager.Instance.LoadScene("clear", 0.5f);
        }
    }

}
