using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using DataPac;

namespace SavePac
{
    public class SaveMethodScript
    {
        // システム変数宣言
        [SerializeField]
        private int[] timeCount = {0, 0, 0, 0}; // 前回の時間
        [SerializeField]
        private int yearCount; // 年の経過数
        [SerializeField]
        private int monthCount; // 月の経過数
        [SerializeField]
        private int monthCountForYear; // 月の経過の絶対数
        [SerializeField]
        private int weekCount; // 週の経過数
        [SerializeField]
        private int classLimitCount; // 最低出席日数
        [SerializeField]
        private int term; // 期

        // ステータス変数宣言
        [SerializeField]
        private int stamina; // スタミナ
        [SerializeField]
        private int exp; // 経験値
        [SerializeField]
        private int studyLevel; // かしこさレベル
        [SerializeField]
        private int loveLevel; // れんあいレベル
        [SerializeField]
        private int friendLevel; // ともだちレベル
        [SerializeField]
        private int ownMoney; // 所持金
        [SerializeField]
        private int unit = 0; // 総単位数
        [SerializeField]
        private float[] termGPA = {0, 0, 0, 0, 0, 0}; // 学期ごとの成績
        [SerializeField]
        private int[] ownGPAOne = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; // 1年前期成績
        [SerializeField]
        private int[] ownGPATwo = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; // 1年後期成績
        [SerializeField]
        private int[] ownGPAThree= {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; // 2年前期成績
        [SerializeField]
        private int[] ownGPAFour = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}; // 2年後期成績
        [SerializeField]
        private int[] ownGPAFive = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};// 3年前期成績
        [SerializeField]
        private int[] ownGPASix = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};// 3年後期成績
        [SerializeField]
        private int[] ownCircleCount = {0}; // サークルの有無(0:無 1:有)
        [SerializeField]
        private string[] ownCircle = {"空き"}; // サークル
        [SerializeField]
        private int[] ownGirlCount = {0, 0, 0, 0, 0, 0}; // 彼女の有無(0:無 1:有)
        [SerializeField]
        private string[] ownGirl = {"空き", "空き", "空き", "空き", "空き", "空き"}; // 彼女

        // セーブ
        public void Save(DataScript data)
        {
            SaveMethodScript methoddata = new SaveMethodScript();

            // システム変数ゲット
            methoddata.timeCount = data.TimeCount;
            methoddata.yearCount = data.YearCount;
            methoddata.monthCount = data.MonthCount;
            methoddata.monthCountForYear = data.MonthCountForYear;
            methoddata.weekCount = data.WeekCount;
            methoddata.classLimitCount = data.ClassLimitCount;
            methoddata.term = data.Term;

            // ステータス変数ゲット
            methoddata.stamina = data.Stamina;
            methoddata.exp = data.Exp;
            methoddata.studyLevel = data.StudyLevel;
            methoddata.loveLevel = data.LoveLevel;
            methoddata.friendLevel = data.FriendLevel;
            methoddata.ownMoney = data.OwnMoney;
            methoddata.unit = data.Unit;
            methoddata.termGPA = data.TermGPA;
            methoddata.ownGPAOne = data.OwnGPAOne;
            methoddata.ownGPATwo = data.OwnGPATwo;
            methoddata.ownGPAThree = data.OwnGPAThree;
            methoddata.ownGPAFour = data.OwnGPAFour;
            methoddata.ownGPAFive = data.OwnGPAFive;
            methoddata.ownGPASix = data.OwnGPASix;
            methoddata.ownCircleCount = data.OwnCircleCount;
            methoddata.ownCircle = data.OwnCircle;
            methoddata.ownGirlCount = data.OwnGirlCount;
            methoddata.ownGirl = data.OwnGirl;

            StreamWriter writer;
            string jsonData = JsonUtility.ToJson(methoddata);
            writer = new StreamWriter(Application.persistentDataPath + "/savedata.json", false); // trueで追記、falseで上書き
            writer.Write(jsonData);
            writer.Flush();
            writer.Close();
        }

        // ロード
        public DataScript Load()
        {
            SaveMethodScript methoddata = new SaveMethodScript();
            string readdata = "";
            StreamReader reader;

            reader = new StreamReader(Application.persistentDataPath + "/savedata.json");
            readdata = reader.ReadToEnd();
            reader.Close();

            methoddata = JsonUtility.FromJson<SaveMethodScript>(readdata);

            DataScript data = new DataScript();

            // システム変数セット
            data.TimeCount = methoddata.timeCount;
            data.YearCount = methoddata.yearCount;
            data.MonthCount = methoddata.monthCount;
            data.MonthCountForYear = methoddata.monthCountForYear;
            data.WeekCount = methoddata.weekCount;
            data.ClassLimitCount = methoddata.classLimitCount;
            data.Term = methoddata.term;

            // ステータス変数セット
            data.Stamina = methoddata.stamina;
            data.Exp = methoddata.exp;
            data.StudyLevel = methoddata.studyLevel;
            data.LoveLevel = methoddata.loveLevel;
            data.FriendLevel = methoddata.friendLevel;
            data.OwnMoney = methoddata.ownMoney;
            data.Unit = methoddata.unit;
            data.TermGPA = methoddata.termGPA;
            data.OwnGPAOne = methoddata.ownGPAOne;
            data.OwnGPATwo = methoddata.ownGPATwo;
            data.OwnGPAThree = methoddata.ownGPAThree;
            data.OwnGPAFour = methoddata.ownGPAFour;
            data.OwnGPAFive = methoddata.ownGPAFive;
            data.OwnGPASix = methoddata.ownGPASix;
            data.OwnCircleCount = methoddata.ownCircleCount;
            data.OwnCircle = methoddata.ownCircle;
            data.OwnGirlCount = methoddata.ownGirlCount;
            data.OwnGirl = methoddata.ownGirl;

            return data;
        }

        // セーブデータ削除
        public void DeleteData()
        {
            System.IO.File.Delete(Application.persistentDataPath + "/savedata.json");
        }
        
    }
}
