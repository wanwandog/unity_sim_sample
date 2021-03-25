using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class CircleMainScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    // Black
    public GameObject circleTwoBlack;
    public GameObject circleThreeBlack;
    public GameObject circleFourBlack;
    public GameObject circleFiveBlack;
    public GameObject circleSixBlack;

    void Start()
    {
        DataScript data = save.Load();

        circleTwoBlack.SetActive(true);
        circleThreeBlack.SetActive(true);
        circleFourBlack.SetActive(true);
        circleFiveBlack.SetActive(true);
        circleSixBlack.SetActive(true);

        BlackRelease(data);
    }

    private void BlackRelease(DataScript data)
    {
        if (data.FriendLevel >= 5)
        {
            circleTwoBlack.SetActive(false);
        }
        if (data.FriendLevel >= 10)
        {
            circleThreeBlack.SetActive(false);
        }

        if (data.FriendLevel >= 15)
        {
            circleFourBlack.SetActive(false);
        }
        if (data.FriendLevel >= 20)
        {
            circleFiveBlack.SetActive(false);
        }
        
        if (data.StudyLevel >= 20 & data.LoveLevel >= 20 & data.FriendLevel >= 20)
        {
            circleSixBlack.SetActive(false);
        }
    }
}
