using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class ActionScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    // バイト
    public void OnClickJobButton()
    {
        SceneManager.LoadScene("Job");
    }

    // サークル
    public void OnClickCircleButton()
    {
        SceneManager.LoadScene("Circle");
    }

    // 友だち
    public void OnClickFriendButton()
    {
        SceneManager.LoadScene("Friend");
    }

    // 彼女
    public void OnClickGirlButton()
    {
        SceneManager.LoadScene("Girl");
    }

    // 買い物
    public void OnClickShopButton()
    {
        SceneManager.LoadScene("Shop");
    }

    // 成績
    public void OnClickGPAButton()
    {
        SceneManager.LoadScene("GPA");
    }
}
