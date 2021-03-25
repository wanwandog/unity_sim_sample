using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class GirlMainScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    // Black
    public GameObject girlTwoBlack;
    public GameObject girlThreeBlack;
    public GameObject girlFourBlack;
    public GameObject girlFiveBlack;
    public GameObject girlSixBlack;

    void Start()
    {
        DataScript data = save.Load();

        girlTwoBlack.SetActive(true);
        girlThreeBlack.SetActive(true);
        girlFourBlack.SetActive(true);
        girlFiveBlack.SetActive(true);
        girlSixBlack.SetActive(true);

        BlackRelease(data);
    }

    private void BlackRelease(DataScript data)
    {
        if (data.LoveLevel >= 5)
        {
            girlTwoBlack.SetActive(false);
        }
        if (data.LoveLevel >= 10)
        {
            girlThreeBlack.SetActive(false);
        }

        if (data.LoveLevel >= 15)
        {
            girlFourBlack.SetActive(false);
        }
        if (data.LoveLevel >= 20)
        {
            girlFiveBlack.SetActive(false);
        }
        
        if (data.StudyLevel >= 20 & data.LoveLevel >= 20 & data.FriendLevel >= 20)
        {
            girlSixBlack.SetActive(false);
        }
    }
}
