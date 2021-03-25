using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataPac
{
    public class DataScript
    {
        // システム変数宣言

        // 前回の時間(日/時/分/秒)
        private int[] timeCount = {0, 0, 0, 0};
        public int[] TimeCount
        {
            get {return timeCount;}
            set {timeCount = value;}
        }

        private int yearCount = 1; // 年の経過数
        public int YearCount
        {
            get {return yearCount;}
            set {yearCount = value;}
        }

        private int monthCount = 6; // 月の経過数
        public int MonthCount
        {
            get {return monthCount;}
            set {monthCount = value;}
        }

        private int monthCountForYear = 0; // 月の経過の絶対数
        public int MonthCountForYear
        {
            get {return monthCountForYear;}
            set {monthCountForYear = value;}
        }

        private int weekCount = 1; // 週の経過数
        public int WeekCount
        {
            get {return weekCount;}
            set {weekCount = value;}
        }

        private int classLimitCount = 5; // 最低出席日数
        public int ClassLimitCount
        {
            get {return classLimitCount;}
            set {classLimitCount = value;}
        }

        private int term = 0; // 期(1年前期を0として5までの6期)
        public int Term
        {
            get {return term;}
            set {term = value;}
        }

        // ステータス変数宣言
        private int stamina = 100; // スタミナ
        public int Stamina
        {
            get {return stamina;}
            set {stamina = value;}
        }

        private int exp = 100000; // 経験値
        public int Exp
        {
            get {return exp;}
            set {exp = value;}
        }


        private int studyLevel = 1; // かしこさレベル
        public int StudyLevel
        {
            get {return studyLevel;}
            set {studyLevel = value;}
        }

        private int loveLevel = 1; // れんあいレベル
        public int LoveLevel
        {
            get {return loveLevel;}
            set {loveLevel = value;}
        }

        private int friendLevel = 1; // ともだちレベル
        public int FriendLevel
        {
            get {return friendLevel;}
            set {friendLevel = value;}
        }

        private int ownMoney = 0; // 所持金
        public int OwnMoney
        {
            get {return ownMoney;}
            set {ownMoney = value;}
        }

        // 総単位数
        private int unit = 0;
        public int Unit
        {
            get {return unit;}
            set {unit = value;}
        }

        // 学期ごとの成績
        private float[] termGPA = {0, 0, 0, 0, 0, 0};
        public float[] TermGPA
        {
            get {return termGPA;}
            set {termGPA = value;}
        }

        // 1年前期成績
        private int[] ownGPAOne = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        public int[] OwnGPAOne
        {
            get {return ownGPAOne;}
            set {ownGPAOne = value;}
        }
        // 1年後期成績
        private int[] ownGPATwo = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        public int[] OwnGPATwo
        {
            get {return ownGPATwo;}
            set {ownGPATwo = value;}
        }
        // 2年前期成績
        private int[] ownGPAThree= {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        public int[] OwnGPAThree
        {
            get {return ownGPAThree;}
            set {ownGPAThree = value;}
        }
        // 2年後期成績
        private int[] ownGPAFour = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        public int[] OwnGPAFour
        {
            get {return ownGPAFour;}
            set {ownGPAFour = value;}
        }
        // 3年前期成績
        private int[] ownGPAFive = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        public int[] OwnGPAFive
        {
            get {return ownGPAFive;}
            set {ownGPAFive = value;}
        }
        // 3年後期成績
        private int[] ownGPASix = {10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10};
        public int[] OwnGPASix
        {
            get {return ownGPASix;}
            set {ownGPASix = value;}
        }

        private int[] ownCircleCount = {0}; // サークルの有無(0:無 1:有)
        public int[] OwnCircleCount
        {
            get {return ownCircleCount;}
            set {ownCircleCount = value;}
        }

        private string[] ownCircle = {"空き"}; // サークル
        public string[] OwnCircle
        {
            get {return ownCircle;}
            set {ownCircle = value;}
        }

        private int[] ownGirlCount = {0, 0, 0, 0, 0, 0}; // 彼女の有無(0:無 1:有)
        public int[] OwnGirlCount
        {
            get {return ownGirlCount;}
            set {ownGirlCount = value;}
        }

        private string[] ownGirl = {"空き", "空き", "空き", "空き", "空き", "空き"}; // 彼女
        public string[] OwnGirl
        {
            get {return ownGirl;}
            set {ownGirl = value;}
        }
    }

    public class DataScriptConst
    {
        // レベルアップの基準(MAX:25)
        private int[] levelUpBorder = {10, 30, 60, 100, 150, 210, 280, 360, 450, 550, 660, 780, 910, 1050, 1200, 1360, 1530, 1710, 1900, 2100, 2310, 2530, 2760, 3000, 3250};
        public int[] LevelUpBorder
        {
            get {return levelUpBorder;}
        }

        // 科目データ
        private string[] subjectOneData = {"大学生活論", "英語基礎A", "数学基礎A", "物理学基礎A", "化学基礎A", "生物学基礎A", "社会学基礎A", "ドイツ語基礎A", "統計学入門", "プログラミング入門", "芸術入門", "健康学入門"};
        public string[] SubjectOneData
        {
            get {return subjectOneData;}
        }
        private string[] subjectTwoData = {"ゼミ入門", "英語基礎", "数学基礎B", "物理学基礎B", "化学基礎B", "生物学基礎B", "社会学基礎B", "ドイツ語基礎B", "哲学入門", "日本史入門", "世界史入門", "スポーツ科学入門"};
        public string[] SubjectTwoData
        {
            get {return subjectTwoData;}
        }
            private string[] subjectThreeData = {"", "", "", "", "", "", "", "", "", "", "", ""};
        public string[] SubjectThreeData
        {
            get {return subjectThreeData;}
        }
        private string[] subjectFourData = {"", "", "", "", "", "", "", "", "", "", "", ""};
        public string[] SubjectFourData
        {
            get {return subjectFourData;}
        }
        private string[] subjectFiveData = {"", "", "", "", "", "", "", "", "", "", "", ""};
        public string[] SubjectFiveData
        {
            get {return subjectFiveData;}
        }
        private string[] subjectSixData = {"", "", "", "", "", "", "", "", "", "", "", ""};
        public string[] SubjectSixData
        {
            get {return subjectSixData;}
        }

        // レベルの基準6期分
        private int[] levelBorder = {3, 7, 11, 15, 17, 20};
        public int[] LevelBorder
        {
            get {return levelBorder;}
        }
        // レベルマックス6期分
        private int[] levelMax = {7, 11, 15, 17, 20, 22};
        public int[] LevelMax
        {
            get {return levelMax;}
        }

        // サークルデータ
        private string[] circleData = {"バドミントン"};
        public string[] CircleData
        {
            get {return circleData;}
        }

        // 彼女データ
        private string[] girlData = {"あい", "れん", "えいみ", "あん", "みかこ", "なな"};
        public string[] GirlData
        {
            get {return girlData;}
        }

    }
}