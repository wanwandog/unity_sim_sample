using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class CircleScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    public GameObject circleIventPanel;
    public GameObject circleOneFront;
    public GameObject circleTwoFront;
    public GameObject circleThreeFront;
    public GameObject circleFourFront;
    public GameObject circleFiveFront;
    public GameObject circleSixFront;

    void Start()
    {
        DataScript data = save.Load();

        circleIventPanel.SetActive(false);
    }

    public void OnClickCircleOneButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        circleIventPanel.SetActive(true);
        circleOneFront.SetActive(true);
        circleTwoFront.SetActive(false);
        circleThreeFront.SetActive(false);
        circleFourFront.SetActive(false);
        circleFiveFront.SetActive(false);
        circleSixFront.SetActive(false);
    }

    public void OnClickCircleTwoButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        circleIventPanel.SetActive(true);
        circleOneFront.SetActive(false);
        circleTwoFront.SetActive(true);
        circleThreeFront.SetActive(false);
        circleFourFront.SetActive(false);
        circleFiveFront.SetActive(false);
        circleSixFront.SetActive(false);
    }

    public void OnClickCircleThreeButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        circleIventPanel.SetActive(true);
        circleOneFront.SetActive(false);
        circleTwoFront.SetActive(false);
        circleThreeFront.SetActive(true);
        circleFourFront.SetActive(false);
        circleFiveFront.SetActive(false);
        circleSixFront.SetActive(false);
    }

    public void OnClickCircleFourButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        circleIventPanel.SetActive(true);
        circleOneFront.SetActive(false);
        circleTwoFront.SetActive(false);
        circleThreeFront.SetActive(false);
        circleFourFront.SetActive(true);
        circleFiveFront.SetActive(false);
        circleSixFront.SetActive(false);
    }

    public void OnClickCircleFiveButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        circleIventPanel.SetActive(true);
        circleOneFront.SetActive(false);
        circleTwoFront.SetActive(false);
        circleThreeFront.SetActive(false);
        circleFourFront.SetActive(false);
        circleFiveFront.SetActive(true);
        circleSixFront.SetActive(false);
    }

    public void OnClickCircleSixButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        circleIventPanel.SetActive(true);
        circleOneFront.SetActive(false);
        circleTwoFront.SetActive(false);
        circleThreeFront.SetActive(false);
        circleFourFront.SetActive(false);
        circleFiveFront.SetActive(false);
        circleSixFront.SetActive(true);
    }
}
