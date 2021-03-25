using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;

public class TestScript : MonoBehaviour
{
    // パネル宣言
    public GameObject TestMainPanel;
    public GameObject TestResultPanel;

    void Start()
    {
        TestResultPanel.SetActive(false);

        StartCoroutine("DisplayTestResult");
    }

    // テスト結果パネル表示
    private IEnumerator DisplayTestResult()
    {
        yield return new WaitForSeconds(2.0f);
        TestMainPanel.SetActive(false);
        TestResultPanel.SetActive(true);
    }
}