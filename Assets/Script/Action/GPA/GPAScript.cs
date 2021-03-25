using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class GPAScript : MonoBehaviour
{
    DataScriptConst dataConst = new DataScriptConst();
    SaveMethodScript save = new SaveMethodScript();

    // パネル宣言
    public GameObject gPAMainPanel;
    public GameObject gPATestResultPanel;

        // テキスト宣言
    public Text unitNumber; // 総単位数
    public Text sumGPANumber; // 通算GPA;

    public Text unitSumNumber; // 単位数合計
    public Text termGPANumber; // 学期GPA

    public Text[] subjectText; // 科目
    public Text[] GPANumber; // 成績

    void Start()
    {
        DataScript data = save.Load();
        int i, denominator = 0;
        float sum = 0, termGPA = 0, temp = 0;

        for (i = 0; i < 6; i++)
        {
            if (data.TermGPA[i] != 0.0)
            {
                sum += data.TermGPA[i];
                denominator += 1;
            }
        }

        // 全て0なら未
        if (denominator != 0)
        {
            termGPA = sum / denominator;
            // 小数点第2位以下切り捨て
            temp = termGPA * 10;
            temp = Mathf.Floor(temp);
            termGPA = temp / 10;
            
            sumGPANumber.text = termGPA.ToString();
        } else {
            sumGPANumber.text = "未";
        }

        unitNumber.text = data.Unit.ToString();
        
        gPAMainPanel.SetActive(true);
        gPATestResultPanel.SetActive(false);
    }

    // 学期ごとのボタン
    public void OnClickGPAOneButton()
    {
        DataScript data = save.Load();
            
        DisplayResultSubject(data, 0);
        DisplayResultSum(data, 0);

        gPAMainPanel.SetActive(false);
        gPATestResultPanel.SetActive(true);
    }

    public void OnClickGPATwoButton()
    {
        DataScript data = save.Load();
            
        DisplayResultSubject(data, 1);
        DisplayResultSum(data, 1);

        gPAMainPanel.SetActive(false);
        gPATestResultPanel.SetActive(true);
    }

    public void OnClickGPAThreeButton()
    {
        DataScript data = save.Load();
            
        DisplayResultSubject(data, 2);
        DisplayResultSum(data, 2);

        gPAMainPanel.SetActive(false);
        gPATestResultPanel.SetActive(true);
    }

    public void OnClickGPAFourButton()
    {
        DataScript data = save.Load();
            
        DisplayResultSubject(data, 3);
        DisplayResultSum(data, 3);

        gPAMainPanel.SetActive(false);
        gPATestResultPanel.SetActive(true);
    }

    public void OnClickGPAFiveButton()
    {
        DataScript data = save.Load();
            
        DisplayResultSubject(data, 4);
        DisplayResultSum(data, 4);

        gPAMainPanel.SetActive(false);
        gPATestResultPanel.SetActive(true);
    }

    public void OnClickGPASixButton()
    {
        DataScript data = save.Load();
            
        DisplayResultSubject(data, 5);
        DisplayResultSum(data, 5);

        gPAMainPanel.SetActive(false);
        gPATestResultPanel.SetActive(true);
    }

    // 科目と成績表示
    private void DisplayResultSubject(DataScript data, int term)
    {
        int i;

        switch (term)
        {
            case 0:
                for (i = 0; i < 12; i++)
                {
                    subjectText[i].text = dataConst.SubjectOneData[i];
                    GPANumber[i].text = SABC(data.OwnGPAOne[i]);
                }
                break;
            case 1:
                for (i = 0; i < 12; i++)
                {
                    subjectText[i].text = dataConst.SubjectTwoData[i];
                    GPANumber[i].text = SABC(data.OwnGPATwo[i]);
                }
                break;
            case 2:
                for (i = 0; i < 12; i++)
                {
                    subjectText[i].text = dataConst.SubjectThreeData[i];
                    GPANumber[i].text = SABC(data.OwnGPAThree[i]);
                }
                break;
            case 3:
                for (i = 0; i < 12; i++)
                {
                    subjectText[i].text = dataConst.SubjectFourData[i];
                    GPANumber[i].text = SABC(data.OwnGPAFour[i]);
                }
                break;
            case 4:
                for (i = 0; i < 12; i++)
                {
                    subjectText[i].text = dataConst.SubjectFiveData[i];
                    GPANumber[i].text = SABC(data.OwnGPAFive[i]);
                }
                break;
            case 5:
                for (i = 0; i < 12; i++)
                {
                    subjectText[i].text = dataConst.SubjectSixData[i];
                    GPANumber[i].text = SABC(data.OwnGPASix[i]);
                }
                break;
        }
    }

    // GPAをSABCに変換
    private string SABC(int gpa)
    {
        switch(gpa)
        {
            case 4:
                return "S";
            case 3:
                return "A";
            case 2:
                return "B";
            case 1:
                return "C";
            case 0:
                return "不可";
            case 10:
                return "未";
        }

        return "XX";
    }

    // 合計表示
    private void DisplayResultSum(DataScript data, int term)
    {
        int i, unitSum = 0;
        float sum = 0, average = 0, temp = 0;

        switch (term)
        {
            case 0:
                for (i = 0; i < 12; i++)
                {
                    if (data.OwnGPAOne[i] != 0) {
                        unitSum += 2;
                    }
                    sum += data.OwnGPAOne[i] * 2;
                }
                break;
            case 1:
                for (i = 0; i < 12; i++)
                {
                    if (data.OwnGPATwo[i] != 0) {
                        unitSum += 2;
                    }
                    sum += data.OwnGPATwo[i] * 2;
                }
                break;
            case 2:
                for (i = 0; i < 12; i++)
                {
                    if (data.OwnGPAThree[i] != 0) {
                        unitSum += 2;
                    }
                    sum += data.OwnGPAThree[i] * 2;
                }
                break;
            case 3:
                for (i = 0; i < 12; i++)
                {
                    if (data.OwnGPAFour[i] != 0) {
                        unitSum += 2;
                    }
                    sum += data.OwnGPAFour[i] * 2;
                }
                break;
            case 4:
                 for (i = 0; i < 12; i++)
                {
                    if (data.OwnGPAFive[i] != 0) {
                        unitSum += 2;
                    }
                    sum += data.OwnGPAFive[i] * 2;
                }
                break;
            case 5:
                for (i = 0; i < 12; i++)
                {
                    if (data.OwnGPASix[i] != 0) {
                        unitSum += 2;
                    }
                    sum += data.OwnGPASix[i] * 2;
                }
                break;
        }

        // 小数点第2位切り捨て
        average = sum / 24;
        temp = average * 10;
        temp = Mathf.Floor(temp);
        average = temp / 10;

        unitSumNumber.text = unitSum.ToString();

        // 初期値10のままなら未
        if (average == 10)
        {
            termGPANumber.text = "未";
        } else {
            termGPANumber.text = average.ToString();
        }
    }

    // 戻る
    public void OnClickBackButton()
    {
        gPAMainPanel.SetActive(true);
        gPATestResultPanel.SetActive(false);
    }
}