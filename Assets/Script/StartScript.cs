using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DataPac;
using SavePac;


public class StartScript : MonoBehaviour
{
    DataScript data = new DataScript();
    SaveMethodScript save = new SaveMethodScript();

    
    void Start()
    {
        // if (System.IO.File.Exists(Application.persistentDataPath + "/savedata.json") == false)
        // {
        //     save.ResetData();
        // }
        Debug.Log(Application.persistentDataPath + "/savedata.json");
        save.Save(data);
        Debug.Log(Application.persistentDataPath);
    }

    public void OnClickStartButton()
    {
        SceneManager.LoadScene("Main");
    }

}
