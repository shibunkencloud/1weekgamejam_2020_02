using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
   public void OnClickStartButton()
    {
        SceneManager.LoadScene("Description");
    }
    public void OnClickOkButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
