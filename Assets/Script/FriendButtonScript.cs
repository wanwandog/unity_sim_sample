using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FriendButtonScript : MonoBehaviour
{
    public void OnClickFriendButton()
    {
        SceneManager.LoadScene("Friend");
    }
}
