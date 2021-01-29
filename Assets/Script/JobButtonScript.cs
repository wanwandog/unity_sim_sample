using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JobButtonScript : MonoBehaviour
{
    public void OnClickJobButton()
    {
        SceneManager.LoadScene("Job");
    }
}
