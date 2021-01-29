using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassButtonScript : MonoBehaviour
{
    public void OnClickClassButton()
    {
        SceneManager.LoadScene("Class");
    }
}
