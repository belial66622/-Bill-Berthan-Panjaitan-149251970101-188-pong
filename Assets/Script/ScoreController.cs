using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    // Start is called before the first frame update
    public Text skorKiri;
    public Text skorKanan;

    public Scoremanager manager;

    void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();

    }

    public void kemenu()
    {

        SceneManager.LoadScene(0);
    }
}
