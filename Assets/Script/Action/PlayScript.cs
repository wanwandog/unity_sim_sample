using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class PlayScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    // パネル宣言
    public GameObject playMainPanel;
    public GameObject shopPanel;
    public GameObject circlePanel;
    public GameObject friendPanel;
    public GameObject girlPanel;

    void Start()
    {
        DataScript data = save.Load();

        OnClickPlayMainButton();
    }

    // MainPanelを常に最初に表示
    void Update()
    {
        if (playMainPanel.activeSelf == true)
        {
            shopPanel.SetActive(false);
            circlePanel.SetActive(false);
            friendPanel.SetActive(false);
            girlPanel.SetActive(false);
        }
    }

    // パネル表示調整
    public void OnClickPlayMainButton()
    {
        playMainPanel.SetActive(true);
        shopPanel.SetActive(false);
        circlePanel.SetActive(false);
        friendPanel.SetActive(false);
        girlPanel.SetActive(false);
    }

    public void OcClickShopButton() 
    {   
        playMainPanel.SetActive(false);
        shopPanel.SetActive(true);
        circlePanel.SetActive(false);
        friendPanel.SetActive(false);
        girlPanel.SetActive(false);
    }

    public void OnClickCircleButton() {
        playMainPanel.SetActive(false);
        shopPanel.SetActive(false);
        circlePanel.SetActive(true);
        friendPanel.SetActive(false);
        girlPanel.SetActive(false);
    }

    public void OnClickFriendButton() {
        playMainPanel.SetActive(false);
        shopPanel.SetActive(false);
        circlePanel.SetActive(false);
        friendPanel.SetActive(true);
        girlPanel.SetActive(false);
    }

    public void OnClickGirlButton() {
        playMainPanel.SetActive(false);
        shopPanel.SetActive(false);
        circlePanel.SetActive(false);
        friendPanel.SetActive(false);
        girlPanel.SetActive(true);
    }

    // 友達と遊ぶ
    public void OnClickFriendPlayButton() {
        SceneManager.LoadScene("Friend");
    }
}
