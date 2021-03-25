using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class MainScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    private int day = 0, hour = 0, minute = 0, second = 0, time = 0;

    // システム変数宣言
    public Text yearNumber;
    public Text monthNumber;
    public Text weekNumber;
    //ステータス変数宣言
    public Text staminaNumber;
    public Text studyLevelNumber;
    public Text loveLevelNumber;
    public Text friendLevelNumber;
    public Text ownMoneyNumber;

    // ラーメン
    public GameObject ramenOne;
    public GameObject ramenTwo;
    public GameObject ramenThree;
    public GameObject ramenFour;
    public GameObject ramenFive;

    // パネル宣言
    public GameObject headerPanel;
    public GameObject homePanel;
    public GameObject classPanel;
    public GameObject actionPanel;
    public GameObject footerPanel;
    public GameObject classIventPanel;

    void Awake()
    {
        DataScript data = save.Load();

        AwakeNonDisplay();

        time = TimeReturn(data);
        
        RamenDisplay(time);

        TimeSave(data);

        // 時間調整
        if (data.WeekCount == 5)
        {
            data.WeekCount = 1;
            data.MonthCount += 1;
            data.MonthCountForYear += 1;
            
            if (data.MonthCount == 13)
            {
                data.MonthCount = 1;
            }

            if (data.MonthCountForYear == 12)
            {
                data.MonthCountForYear = 0;
                data.YearCount += 1;
            }

            save.Save(data);
        }

        OnClickHomeButton();
        
        // システム変数表示
        yearNumber.text = data.YearCount.ToString();
        monthNumber.text = data.MonthCount.ToString();
        weekNumber.text = data.WeekCount.ToString();
        // ステータス変数表示
        staminaNumber.text = data.Stamina.ToString();
        studyLevelNumber.text = data.StudyLevel.ToString();
        loveLevelNumber.text = data.LoveLevel.ToString();
        friendLevelNumber.text = data.FriendLevel.ToString();
        ownMoneyNumber.text = data.OwnMoney.ToString();
    }

    // 初期非表示パネル
    public void AwakeNonDisplay()
    {
        // イベントパネル非表示
        classIventPanel.SetActive(false);

        // ラーメン非表示
        ramenOne.SetActive(false);
        ramenTwo.SetActive(false);
        ramenThree.SetActive(false);
        ramenFour.SetActive(false);
        ramenFive.SetActive(false);

    }

    // 経過時間の絶対値を返す
    public int TimeReturn(DataScript data)
    {
        int dayDiff = 0, hourDiff = 0, minuteDiff = 0, secondDiff = 0, sumSecond = 0;

        // 現在時刻取得
        day = DateTime.Now.Day;
        hour = DateTime.Now.Hour;
        minute = DateTime.Now.Minute;
        second = DateTime.Now.Second;

        // 差の計算
        dayDiff = Math.Abs(day - data.TimeCount[0]);
        hourDiff = Math.Abs(hour - data.TimeCount[1]);
        minuteDiff = Math.Abs(minute - data.TimeCount[2]);
        secondDiff = Math.Abs(second - data.TimeCount[3]);

        sumSecond = dayDiff*24*60*60 + hourDiff*60*60 + minuteDiff*60 + secondDiff;
        Debug.Log(sumSecond);

        return sumSecond;
    }

    // 経過時間の絶対値からラーメンの表示
    public void RamenDisplay(int time)
    {
        if (time > 60)
        {
            ramenOne.SetActive(true);
        }
        if (time > 120)
        {
            ramenTwo.SetActive(true);
        }
        if (time > 180)
        {
            ramenThree.SetActive(true);
        }
        if (time > 240)
        {
            ramenFour.SetActive(true);
        }
        if (time > 300)
        {
            ramenFive.SetActive(true);
        }
    }

    // 現在時刻のセーブ
    public void TimeSave(DataScript data)
    {
        data.TimeCount[0] = DateTime.Now.Day;
        data.TimeCount[1] = DateTime.Now.Hour;
        data.TimeCount[2] = DateTime.Now.Minute;
        data.TimeCount[3] = DateTime.Now.Second;

        save.Save(data);
    }

    // レベルアップ押下
    public void OnClickLevelUpButton()
    {
        SceneManager.LoadScene("LevelUp");
    }

    // パネル表示調整
    public void OnClickHomeButton()
    {
        homePanel.SetActive(true);
        classPanel.SetActive(false);
        actionPanel.SetActive(false);
    }

    public void OcClickClassButton() 
    {   
        homePanel.SetActive(false);
        classPanel.SetActive(true);
        actionPanel.SetActive(false);
    }

    public void OnClickActionButton() {
        homePanel.SetActive(false);
        classPanel.SetActive(false);
        actionPanel.SetActive(true);
    }


    // オプション押下
    public void OnClickOptionButton() {
        SceneManager.LoadScene("Option");
    }

    // ラーメンタッチ
    public void OnTouchRamenOne()
    {
        DataScript data = save.Load();

        data.Stamina += 1;

        save.Save(data);

        ramenOne.SetActive(false);
    }
    public void OnTouchRamenTwo()
    {
        DataScript data = save.Load();

        data.Stamina += 1;

        save.Save(data);

        ramenTwo.SetActive(false);
    }
    public void OnTouchRamenThree()
    {
        DataScript data = save.Load();

        data.Stamina += 1;

        save.Save(data);

        ramenThree.SetActive(false);
    }
    public void OnTouchRamenFour()
    {
        DataScript data = save.Load();

        data.Stamina += 1;

        save.Save(data);

        ramenFour.SetActive(false);
    }
    public void OnTouchRamenFive()
    {
        DataScript data = save.Load();

        data.Stamina += 1;

        save.Save(data);

        ramenFive.SetActive(false);
    }
}
