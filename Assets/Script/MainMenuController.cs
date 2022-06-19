using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject mainmenu, credit;

    public void PlayGame()
    {
        Debug.Log("Created by Bill Berthan Panjaitan-149251970101-188");

        SceneManager.LoadScene("SampleScene");
    }

    public void OpenAuthor()
    {
        Debug.Log("ini button");
    }

    public void Credit()
    {
        mainmenu.SetActive(false);
        credit.SetActive(true);
    }

    public void Back()
    {
        mainmenu.SetActive(true);
        credit.SetActive(false);
    }
}
