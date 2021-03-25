using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class LevelUpScript : MonoBehaviour
{
    SaveMethodScript save = new SaveMethodScript();
    DataScriptConst dataConst = new DataScriptConst();

    // 経験値表示テキスト
    public Text expNumber;

    // レベル表示テキスト
    public Text studyLevelNumber;
    public Text loveLevelNumber;
    public Text friendLevelNumber;

    // 必要経験値表示テキスト
    public Text studyLevelUpExpNumber;
    public Text loveLevelUpExpNumber;
    public Text friendLevelUpExpNumber;

    // 一時保存パラメータ
    private int expTemp = 0;
    private int studyLevelTemp = 0;
    private int loveLevelTemp = 0;
    private int friendLevelTemp = 0;


    void Start()
    {
        DataScript data = save.Load();

        // 実際のデータを一時保存
        expTemp = data.Exp;
        studyLevelTemp = data.StudyLevel;
        loveLevelTemp = data.LoveLevel;
        friendLevelTemp = data.FriendLevel;

        // テキスト化
        expNumber.text = expTemp.ToString();
        studyLevelNumber.text = studyLevelTemp.ToString();
        studyLevelUpExpNumber.text = dataConst.LevelUpBorder[studyLevelTemp - 1].ToString();
        loveLevelNumber.text = loveLevelTemp.ToString();
        loveLevelUpExpNumber.text = dataConst.LevelUpBorder[loveLevelTemp - 1].ToString();
        friendLevelNumber.text = friendLevelTemp.ToString();
        friendLevelUpExpNumber.text = dataConst.LevelUpBorder[friendLevelTemp - 1].ToString();
    }
    
    // かしこさレベルアップ
    public void OnClickStudyLevelUpButton()
    {
        if (expTemp >= dataConst.LevelUpBorder[studyLevelTemp - 1])
        {
            expTemp -= dataConst.LevelUpBorder[studyLevelTemp - 1];
            studyLevelTemp += 1;

            // テキスト更新
            expNumber.text = expTemp.ToString();
            studyLevelNumber.text = studyLevelTemp.ToString();
            studyLevelUpExpNumber.text = dataConst.LevelUpBorder[studyLevelTemp - 1].ToString();
        }
    }

    // れんあいレベルアップ
    public void OnClickLoveLevelUpButton()
    {
        if (expTemp >= dataConst.LevelUpBorder[loveLevelTemp - 1])
        {
            expTemp -= dataConst.LevelUpBorder[loveLevelTemp - 1];
            loveLevelTemp += 1;

            // テキスト更新
            expNumber.text = expTemp.ToString();
            loveLevelNumber.text = loveLevelTemp.ToString();
            loveLevelUpExpNumber.text = dataConst.LevelUpBorder[loveLevelTemp - 1].ToString();
        }
    }

    // かしこさレベルアップ
    public void OnClickFriendLevelUpButton()
    {
        if (expTemp >= dataConst.LevelUpBorder[friendLevelTemp - 1])
        {
            expTemp -= dataConst.LevelUpBorder[friendLevelTemp - 1];
            friendLevelTemp += 1;

            // テキスト更新
            expNumber.text = expTemp.ToString();
            friendLevelNumber.text = friendLevelTemp.ToString();
            friendLevelUpExpNumber.text = dataConst.LevelUpBorder[friendLevelTemp - 1].ToString();
        }
    }

    // 戻す
    public void OnClickLevelDownButton()
    {
        DataScript data = save.Load();

        // 実際のデータを一時保存
        expTemp = data.Exp;
        studyLevelTemp = data.StudyLevel;
        loveLevelTemp = data.LoveLevel;
        friendLevelTemp = data.FriendLevel;

        // テキスト化
        expNumber.text = expTemp.ToString();
        studyLevelNumber.text = studyLevelTemp.ToString();
        studyLevelUpExpNumber.text = dataConst.LevelUpBorder[studyLevelTemp - 1].ToString();
        loveLevelNumber.text = loveLevelTemp.ToString();
        loveLevelUpExpNumber.text = dataConst.LevelUpBorder[loveLevelTemp - 1].ToString();
        friendLevelNumber.text = friendLevelTemp.ToString();
        friendLevelUpExpNumber.text = dataConst.LevelUpBorder[friendLevelTemp - 1].ToString();
    }


    // 決定
    public void OnClickDecideButton()
    {
        DataScript data = save.Load();

        data.Exp = expTemp;
        data.StudyLevel = studyLevelTemp;
        data.LoveLevel = loveLevelTemp;
        data.FriendLevel = friendLevelTemp;

        save.Save(data);

        SceneManager.LoadScene("Main");
    }
}