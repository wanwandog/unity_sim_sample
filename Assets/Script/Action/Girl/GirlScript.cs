using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class GirlScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    public GameObject girlIventPanel;
    public GameObject girlOneFront;
    public GameObject girlTwoFront;
    public GameObject girlThreeFront;
    public GameObject girlFourFront;
    public GameObject girlFiveFront;
    public GameObject girlSixFront;

    void Start()
    {
        DataScript data = save.Load();

        girlIventPanel.SetActive(false);
    }

    public void OnClickCircleOneButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        girlIventPanel.SetActive(true);
        girlOneFront.SetActive(true);
        girlTwoFront.SetActive(false);
        girlThreeFront.SetActive(false);
        girlFourFront.SetActive(false);
        girlFiveFront.SetActive(false);
        girlSixFront.SetActive(false);
    }

    public void OnClickCircleTwoButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        girlIventPanel.SetActive(true);
        girlOneFront.SetActive(false);
        girlTwoFront.SetActive(true);
        girlThreeFront.SetActive(false);
        girlFourFront.SetActive(false);
        girlFiveFront.SetActive(false);
        girlSixFront.SetActive(false);
    }

    public void OnClickCircleThreeButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        girlIventPanel.SetActive(true);
        girlOneFront.SetActive(false);
        girlTwoFront.SetActive(false);
        girlThreeFront.SetActive(true);
        girlFourFront.SetActive(false);
        girlFiveFront.SetActive(false);
        girlSixFront.SetActive(false);
    }

    public void OnClickCircleFourButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        girlIventPanel.SetActive(true);
        girlOneFront.SetActive(false);
        girlTwoFront.SetActive(false);
        girlThreeFront.SetActive(false);
        girlFourFront.SetActive(true);
        girlFiveFront.SetActive(false);
        girlSixFront.SetActive(false);
    }

    public void OnClickCircleFiveButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        girlIventPanel.SetActive(true);
        girlOneFront.SetActive(false);
        girlTwoFront.SetActive(false);
        girlThreeFront.SetActive(false);
        girlFourFront.SetActive(false);
        girlFiveFront.SetActive(true);
        girlSixFront.SetActive(false);
    }

    public void OnClickCircleSixButton()
    {
        DataScript data = save.Load();
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        girlIventPanel.SetActive(true);
        girlOneFront.SetActive(false);
        girlTwoFront.SetActive(false);
        girlThreeFront.SetActive(false);
        girlFourFront.SetActive(false);
        girlFiveFront.SetActive(false);
        girlSixFront.SetActive(true);
    }
}
