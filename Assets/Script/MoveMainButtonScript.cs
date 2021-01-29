using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveMainButtonScript : MonoBehaviour
{
    public void OnClickBuckButton()
    {
        SaveScript.instance.timeCount += 1;
        Debug.Log(SaveScript.instance.timeCount);
        
        if (SaveScript.instance.timeCount == 3) {
            SceneManager.LoadScene("Ending");
        } else {
            SceneManager.LoadScene("Main");
        }
    }
}
