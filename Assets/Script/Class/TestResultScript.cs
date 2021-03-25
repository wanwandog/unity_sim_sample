using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class TestResultScript : MonoBehaviour
{
    DataScriptConst dataConst = new DataScriptConst();
    SaveMethodScript save = new SaveMethodScript();

    // テキスト宣言
    public Text unitSumNumber; // 単位数合計
    public Text termGPANumber; // 学期GPA

    public Text[] subjectText; // 科目
    public Text[] GPANumber; // 成績

    void Start()
    {
        DataScript data = save.Load();

        switch (data.Term)
        {
            case 0:
                GPAOne(data);
                break;
            case 1:
                GPATwo(data);
                break;
            case 2:
                GPAThree(data);
                break;
            case 3:
                GPAFour(data);
                break;
            case 4:
                GPAFive(data);
                break;
            case 5:
                GPASix(data);
                break;
            default:
                Debug.Log("Error/TestResult/Start");
                break;
        }

        DisplayResultSubject(data);

        DisplayResultSum(data);

    }

    // GPAの計算
    private void GPAOne(DataScript data)
    {

        int i, rand = 0;

        Random.InitState(System.DateTime.Now.Millisecond);

        if (data.ClassLimitCount <= 0) {
            if (data.StudyLevel >= dataConst.LevelBorder[data.Term]) {
                if (data.StudyLevel >= dataConst.LevelMax[data.Term]) {
                    if (data.StudyLevel > dataConst.LevelMax[data.Term]) {
                        // 最高
                        for (i = 0; i < 12; i++) {
                        rand = 8;
                        data.OwnGPAOne[i] = CalculationGPA(rand);
                        }
                    } else {
                        // 最高レベル
                        Debug.Log("saikouLevel");
                        for (i = 0; i < 12; i++) {
                            rand = Random.Range(6, 8);
                            data.OwnGPAOne[i] = CalculationGPA(rand);
                        }
                    }
                } else {
                    // ボーダー以上
                    Debug.Log("ijou");
                    for (i = 0; i < 12; i++) {
                        rand = Random.Range(3, 8);
                        data.OwnGPAOne[i] = CalculationGPA(rand);
                    }
                }
            } else {
                // ボーダー以下
                Debug.Log("ika");
                for (i = 0; i < 12; i++) {
                    rand = Random.Range(0, 7);
                    data.OwnGPAOne[i] = CalculationGPA(rand);
                }
            }
        } else {
            // 出席数未達
            Debug.Log("mitatsu");
            for (i = 0; i < 12; i++) {
                rand = Random.Range(0, 2);
                data.OwnGPAOne[i] = CalculationGPA(rand);
            }
        } 
        
        save.Save(data); // GPA保存
    }

    private void GPATwo(DataScript data)
    {

        int i, rand = 0;

        Random.InitState(System.DateTime.Now.Millisecond);

        if (data.ClassLimitCount <= 0) {
            if (data.StudyLevel >= dataConst.LevelBorder[data.Term]) {
                if (data.StudyLevel >= dataConst.LevelMax[data.Term]) {
                    if (data.StudyLevel > dataConst.LevelMax[data.Term]) {
                        // 最高
                        for (i = 0; i < 12; i++) {
                        rand = 8;
                        data.OwnGPATwo[i] = CalculationGPA(rand);
                        }
                    } else {
                        // 最高レベル
                        Debug.Log("saikouLevel");
                        for (i = 0; i < 12; i++) {
                            rand = Random.Range(6, 8);
                            data.OwnGPATwo[i] = CalculationGPA(rand);
                        }
                    }
                } else {
                    // ボーダー以上
                    Debug.Log("ijou");
                    for (i = 0; i < 12; i++) {
                        rand = Random.Range(3, 8);
                        data.OwnGPATwo[i] = CalculationGPA(rand);
                    }
                }
            } else {
                // ボーダー以下
                Debug.Log("ika");
                for (i = 0; i < 12; i++) {
                    rand = Random.Range(0, 7);
                    data.OwnGPATwo[i] = CalculationGPA(rand);
                }
            }
        } else {
            // 出席数未達
            Debug.Log("mitatsu");
            for (i = 0; i < 12; i++) {
                rand = Random.Range(0, 2);
                data.OwnGPATwo[i] = CalculationGPA(rand);
            }
        } 
        
        save.Save(data); // GPA保存
    }

    private void GPAThree(DataScript data)
    {

        int i, rand = 0;

        Random.InitState(System.DateTime.Now.Millisecond);

        if (data.ClassLimitCount <= 0) {
            if (data.StudyLevel >= dataConst.LevelBorder[data.Term]) {
                if (data.StudyLevel >= dataConst.LevelMax[data.Term]) {
                    if (data.StudyLevel > dataConst.LevelMax[data.Term]) {
                        // 最高
                        for (i = 0; i < 12; i++) {
                        rand = 8;
                        data.OwnGPAThree[i] = CalculationGPA(rand);
                        }
                    } else {
                        // 最高レベル
                        Debug.Log("saikouLevel");
                        for (i = 0; i < 12; i++) {
                            rand = Random.Range(6, 8);
                            data.OwnGPAThree[i] = CalculationGPA(rand);
                        }
                    }
                } else {
                    // ボーダー以上
                    Debug.Log("ijou");
                    for (i = 0; i < 12; i++) {
                        rand = Random.Range(3, 8);
                        data.OwnGPAThree[i] = CalculationGPA(rand);
                    }
                }
            } else {
                // ボーダー以下
                Debug.Log("ika");
                for (i = 0; i < 12; i++) {
                    rand = Random.Range(0, 7);
                    data.OwnGPAThree[i] = CalculationGPA(rand);
                }
            }
        } else {
            // 出席数未達
            Debug.Log("mitatsu");
            for (i = 0; i < 12; i++) {
                rand = Random.Range(0, 2);
                data.OwnGPAThree[i] = CalculationGPA(rand);
            }
        } 
        
        save.Save(data); // GPA保存
    }

    private void GPAFour(DataScript data)
    {

        int i, rand = 0;

        Random.InitState(System.DateTime.Now.Millisecond);

        if (data.ClassLimitCount <= 0) {
            if (data.StudyLevel >= dataConst.LevelBorder[data.Term]) {
                if (data.StudyLevel >= dataConst.LevelMax[data.Term]) {
                    if (data.StudyLevel > dataConst.LevelMax[data.Term]) {
                        // 最高
                        for (i = 0; i < 12; i++) {
                        rand = 8;
                        data.OwnGPAFour[i] = CalculationGPA(rand);
                        }
                    } else {
                        // 最高レベル
                        Debug.Log("saikouLevel");
                        for (i = 0; i < 12; i++) {
                            rand = Random.Range(6, 8);
                            data.OwnGPAFour[i] = CalculationGPA(rand);
                        }
                    }
                } else {
                    // ボーダー以上
                    Debug.Log("ijou");
                    for (i = 0; i < 12; i++) {
                        rand = Random.Range(3, 8);
                        data.OwnGPAFour[i] = CalculationGPA(rand);
                    }
                }
            } else {
                // ボーダー以下
                Debug.Log("ika");
                for (i = 0; i < 12; i++) {
                    rand = Random.Range(0, 7);
                    data.OwnGPAFour[i] = CalculationGPA(rand);
                }
            }
        } else {
            // 出席数未達
            Debug.Log("mitatsu");
            for (i = 0; i < 12; i++) {
                rand = Random.Range(0, 2);
                data.OwnGPAFour[i] = CalculationGPA(rand);
            }
        } 
        
        save.Save(data); // GPA保存
    }

    private void GPAFive(DataScript data)
    {

        int i, rand = 0;

        Random.InitState(System.DateTime.Now.Millisecond);

        if (data.ClassLimitCount <= 0) {
            if (data.StudyLevel >= dataConst.LevelBorder[data.Term]) {
                if (data.StudyLevel >= dataConst.LevelMax[data.Term]) {
                    if (data.StudyLevel > dataConst.LevelMax[data.Term]) {
                        // 最高
                        for (i = 0; i < 12; i++) {
                        rand = 8;
                        data.OwnGPAFive[i] = CalculationGPA(rand);
                        }
                    } else {
                        // 最高レベル
                        Debug.Log("saikouLevel");
                        for (i = 0; i < 12; i++) {
                            rand = Random.Range(6, 8);
                            data.OwnGPAFive[i] = CalculationGPA(rand);
                        }
                    }
                } else {
                    // ボーダー以上
                    Debug.Log("ijou");
                    for (i = 0; i < 12; i++) {
                        rand = Random.Range(3, 8);
                        data.OwnGPAFive[i] = CalculationGPA(rand);
                    }
                }
            } else {
                // ボーダー以下
                Debug.Log("ika");
                for (i = 0; i < 12; i++) {
                    rand = Random.Range(0, 7);
                    data.OwnGPAFive[i] = CalculationGPA(rand);
                }
            }
        } else {
            // 出席数未達
            Debug.Log("mitatsu");
            for (i = 0; i < 12; i++) {
                rand = Random.Range(0, 2);
                data.OwnGPAFive[i] = CalculationGPA(rand);
            }
        } 
        
        save.Save(data); // GPA保存
    }

    private void GPASix(DataScript data)
    {

        int i, rand = 0;

        Random.InitState(System.DateTime.Now.Millisecond);

        if (data.ClassLimitCount <= 0) {
            if (data.StudyLevel >= dataConst.LevelBorder[data.Term]) {
                if (data.StudyLevel >= dataConst.LevelMax[data.Term]) {
                    if (data.StudyLevel > dataConst.LevelMax[data.Term]) {
                        // 最高
                        for (i = 0; i < 12; i++) {
                        rand = 8;
                        data.OwnGPASix[i] = CalculationGPA(rand);
                        }
                    } else {
                        // 最高レベル
                        Debug.Log("saikouLevel");
                        for (i = 0; i < 12; i++) {
                            rand = Random.Range(6, 8);
                            data.OwnGPASix[i] = CalculationGPA(rand);
                        }
                    }
                } else {
                    // ボーダー以上
                    Debug.Log("ijou");
                    for (i = 0; i < 12; i++) {
                        rand = Random.Range(3, 8);
                        data.OwnGPASix[i] = CalculationGPA(rand);
                    }
                }
            } else {
                // ボーダー以下
                Debug.Log("ika");
                for (i = 0; i < 12; i++) {
                    rand = Random.Range(0, 7);
                    data.OwnGPASix[i] = CalculationGPA(rand);
                }
            }
        } else {
            // 出席数未達
            Debug.Log("mitatsu");
            for (i = 0; i < 12; i++) {
                rand = Random.Range(0, 2);
                data.OwnGPASix[i] = CalculationGPA(rand);
            }
        } 
        
        save.Save(data); // GPA保存
    }

    // 個々のGPAの計算
    private int CalculationGPA(int temp)
    {
        switch(temp) 
        {
            case 8:
            case 7:
                return 4;
            case 6:
            case 5:
                return 3;
            case 4:
            case 3:
                return 2;
            case 2:
            case 1:
                return 1;
            case 0:
                return 0;
            default:
                Debug.Log("Error/TestResult");
                break;
        }

        return 1000;
    }

    // 結果表示
    private void DisplayResultSubject(DataScript data)
    {
        int i;

        switch (data.Term)
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
        }

        return "XX";
    }

    private void DisplayResultSum(DataScript data)
    {
        int i, unitSum = 0;
        float sum = 0, average = 0, temp = 0;

        switch (data.Term)
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

        data.Unit += unitSum;

        data.Term += 1;
        data.ClassLimitCount = 0;
        data.WeekCount += 1;

        average = sum / 24;

        data.TermGPA[data.Term] = average;

        save.Save(data);

        // 小数点第2位切り捨て
        temp = average * 10;
        temp = Mathf.Floor(temp);
        average = temp / 10;

        unitSumNumber.text = unitSum.ToString();
        termGPANumber.text = average.ToString();
    }

    public void OnClickBackButton()
    {

        SceneManager.LoadScene("Main");
    }
}