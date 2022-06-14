using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tambahskor : MonoBehaviour
{
    public Collider2D ball;
    public bool isRight;
    public Scoremanager manager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            if (isRight)
            {
                manager.AddRightScore(1);

            }
            else
            {
                manager.AddLeftScore(1);
            }
        }
    }
}
