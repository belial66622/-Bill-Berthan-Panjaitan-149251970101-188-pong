using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        Debug.Log("Created by Bill Berthan Panjaitan-149251970101-188");

        SceneManager.LoadScene("SampleScene");
    }

    public void OpenAuthor()
    {
        Debug.Log("ini button");
    }
}
