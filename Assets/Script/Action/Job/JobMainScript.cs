using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class JobMainScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    // Black
    public GameObject homeTeacherBlack;
    public GameObject teacherBlack;
    public GameObject apparelBlack;
    public GameObject hostBlack;
    public GameObject hallBlack;
    public GameObject internBlack;
    public GameObject iventStaffBlack;

    void Start()
    {
        DataScript data = save.Load();

        homeTeacherBlack.SetActive(true);
        teacherBlack.SetActive(true);
        apparelBlack.SetActive(true);
        hostBlack.SetActive(true);
        hallBlack.SetActive(true);
        internBlack.SetActive(true);
        iventStaffBlack.SetActive(true);

        BlackRelease(data);
    }

    private void BlackRelease(DataScript data)
    {
        if (data.StudyLevel >= 5)
        {
            homeTeacherBlack.SetActive(false);
        }
        if (data.StudyLevel >= 15)
        {
            teacherBlack.SetActive(false);
        }

        if (data.LoveLevel >= 5)
        {
            apparelBlack.SetActive(false);
        }
        if (data.LoveLevel >= 15)
        {
            hostBlack.SetActive(false);
        }

        if (data.FriendLevel >= 5)
        {
            hallBlack.SetActive(false);
        }
        if (data.FriendLevel >= 15)
        {
            internBlack.SetActive(false);
        }
        
        if (data.StudyLevel >= 15 & data.LoveLevel >= 15 & data.FriendLevel >= 15)
        {
            iventStaffBlack.SetActive(false);
        }
    }
}
