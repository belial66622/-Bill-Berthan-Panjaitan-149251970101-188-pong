using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scoremanager : MonoBehaviour
{
    public BallController ball;
    // Start is called before the first frame update
    public int rightScore;
    public int leftScore;
    public int maxScore;

    public void AddRightScore(int increment)
    {
        ball.ResetBall();
        if (rightScore >= maxScore)
        {
            GameOver();
        }

        rightScore += increment;
    }

    public void AddLeftScore(int increment)
    {
        {
            ball.ResetBall();
            if (leftScore >= maxScore)
            {
                GameOver();
            }
            leftScore += increment;
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene("menu");
    }
}
