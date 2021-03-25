using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class JobScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    public GameObject jobIventPanel;
    public GameObject homeTeacherFront;
    public GameObject teacherFront;
    public GameObject apparelFront;
    public GameObject hostFront;
    public GameObject hallFront;
    public GameObject internFront;
    public GameObject oneDayFront;
    public GameObject iventStaffFront;

    void Start()
    {
        DataScript data = save.Load();

        jobIventPanel.SetActive(false);
    }

    public void OnClickHomeTeacherButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 1200;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(true);
        teacherFront.SetActive(false);
        apparelFront.SetActive(false);
        hostFront.SetActive(false);
        hallFront.SetActive(false);
        internFront.SetActive(false);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(false);
    }

    public void OnClickTeacherButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 2000;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(true);
        apparelFront.SetActive(false);
        hostFront.SetActive(false);
        hallFront.SetActive(false);
        internFront.SetActive(false);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(false);
    }

    public void OnClickApparelButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 1200;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(false);
        apparelFront.SetActive(true);
        hostFront.SetActive(false);
        hallFront.SetActive(false);
        internFront.SetActive(false);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(false);
    }

    public void OnClickHostButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 2000;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(false);
        apparelFront.SetActive(false);
        hostFront.SetActive(true);
        hallFront.SetActive(false);
        internFront.SetActive(false);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(false);
    }

    public void OnClickHallButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 1200;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(false);
        apparelFront.SetActive(false);
        hostFront.SetActive(false);
        hallFront.SetActive(true);
        internFront.SetActive(false);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(false);
    }

    public void OnClickInternButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 2000;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(false);
        apparelFront.SetActive(false);
        hostFront.SetActive(false);
        hallFront.SetActive(false);
        internFront.SetActive(true);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(false);
    }

    public void OnClickOneDayButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 1000;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(false);
        apparelFront.SetActive(false);
        hostFront.SetActive(false);
        hallFront.SetActive(false);
        internFront.SetActive(false);
        oneDayFront.SetActive(true);
        iventStaffFront.SetActive(false);
    }

    public void OnClickIventStaffButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;
        data.OwnMoney += 3000;

        save.Save(data);

        jobIventPanel.SetActive(true);
        homeTeacherFront.SetActive(false);
        teacherFront.SetActive(false);
        apparelFront.SetActive(false);
        hostFront.SetActive(false);
        hallFront.SetActive(false);
        internFront.SetActive(false);
        oneDayFront.SetActive(false);
        iventStaffFront.SetActive(true);
    }
}
