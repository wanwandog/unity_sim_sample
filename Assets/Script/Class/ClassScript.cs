using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class ClassScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();

    // パネル宣言
    public GameObject classMainPanel;
    public GameObject testPanel;
    public GameObject vacationPanel;

    public GameObject classIventPanel;
    public GameObject attendFront;
    public GameObject insteadFriendFront;
    public GameObject exitFront;
    public GameObject exitMissFront;
    public GameObject studyFront;
    public GameObject unitGetFront;

    // テキスト宣言
    public Text limitNumber; // 最低出席日数
    public Text errorText; // エラーメッセージ
    public Text attendStudyLevelNumber;
    public Text attendExpNumber; // 出席の経験値
    public Text studyStudyLevelNumber;
    public Text studyExpNumber; // 勉強の経験値

    void Start() {
        // 最低出席日数表示
        DataScript data = save.Load();
        limitNumber.text = data.ClassLimitCount.ToString();

        switch (data.MonthCount)
        {
            case 1:
            case 7:
                if (data.WeekCount == 4)
                {
                    classMainPanel.SetActive(false);
                    testPanel.SetActive(true);
                    vacationPanel.SetActive(false);
                } else{
                    classMainPanel.SetActive(true);
                    testPanel.SetActive(false);
                    vacationPanel.SetActive(false);               
                }
                break;
            case 2:
            case 3:
            case 8:
            case 9:
                    classMainPanel.SetActive(false);
                    testPanel.SetActive(false);
                    vacationPanel.SetActive(true);
                    break;
            default:
                classMainPanel.SetActive(true);
                testPanel.SetActive(false);
                vacationPanel.SetActive(false);
                break;                
        }
    }

    void Update()
    {
        if (classMainPanel.activeSelf == true)
        {
            testPanel.SetActive(false);
            vacationPanel.SetActive(false);
        }
    }

    // 出席
    public void OnClickAttendButton()
    {
        DataScript data = save.Load();

        data.Exp += data.StudyLevel * 10;
        attendStudyLevelNumber.text = data.StudyLevel.ToString(); // かしこさレベル表示
        attendExpNumber.text = (data.StudyLevel * 10).ToString(); // 経験値表示
        data.WeekCount += 1;
        data.ClassLimitCount -= 1;
        data.Stamina -= 1;

        save.Save(data);

        classIventPanel.SetActive(true);
        attendFront.SetActive(true);
        insteadFriendFront.SetActive(false);
        exitFront.SetActive(false);
        exitMissFront.SetActive(false);
        studyFront.SetActive(false);
        unitGetFront.SetActive(false);
    }

    // 友達に出てもらう
    public void OnClickInsteadFriendButton()
    {   
        DataScript data = save.Load();

        if (data.FriendLevel == 1) {
            errorText.text = "これ以上レベルは下がりません";
        } else {
            data.FriendLevel -= 1;
            data.WeekCount += 1;
            data.ClassLimitCount -= 1;
            data.Stamina -= 1;

            save.Save(data);

            classIventPanel.SetActive(true);
            attendFront.SetActive(false);
            insteadFriendFront.SetActive(true);
            exitFront.SetActive(false);
            exitMissFront.SetActive(false);
            studyFront.SetActive(false);
            unitGetFront.SetActive(false);
        }
    }

    // 途中で抜け出す
    public void OnClickExitButton()
    {
        DataScript data = save.Load();

        int rand;
        rand = Random.Range(1, 100);

        Debug.Log("ExitRandomNumber:"+rand);

        if (rand < 6) 
        {
            // 成績の処理
            classIventPanel.SetActive(true);
            attendFront.SetActive(false);
            insteadFriendFront.SetActive(true);
            exitFront.SetActive(false);
            exitMissFront.SetActive(true);
            studyFront.SetActive(false);
            unitGetFront.SetActive(false);
        } else {

            data.ClassLimitCount -= 1;

            save.Save(data);

            classIventPanel.SetActive(true);
            attendFront.SetActive(false);
            insteadFriendFront.SetActive(false);
            exitFront.SetActive(true);
            exitMissFront.SetActive(false);
            studyFront.SetActive(false);
            unitGetFront.SetActive(false);
        }
    }

    // テストを受ける
    public void OnClickTestButton()
    {
        SceneManager.LoadScene("Test");
    }

    // 勉強
    public void OnClickStudyButton()
    {
        DataScript data = save.Load();

        data.Exp += data.StudyLevel * 10;
        studyStudyLevelNumber.text = data.StudyLevel.ToString(); // かしこさレベル表示
        studyExpNumber.text = (data.StudyLevel * 10).ToString(); // 経験値表示
        data.WeekCount += 1;
        data.Stamina -= 1;

        save.Save(data);

        classIventPanel.SetActive(true);
        attendFront.SetActive(false);
        insteadFriendFront.SetActive(false);
        exitFront.SetActive(false);
        exitMissFront.SetActive(false);
        studyFront.SetActive(true);
        unitGetFront.SetActive(false);
    }

    public void OnClickUnitGetButton()
    {
        DataScript data = save.Load();

        data.WeekCount += 1;
        data.Stamina -= 1;
        data.Unit += 1;

        save.Save(data);

        classIventPanel.SetActive(true);
        attendFront.SetActive(false);
        insteadFriendFront.SetActive(false);
        exitFront.SetActive(false);
        exitMissFront.SetActive(false);
        studyFront.SetActive(false);
        unitGetFront.SetActive(true);
    }
}
