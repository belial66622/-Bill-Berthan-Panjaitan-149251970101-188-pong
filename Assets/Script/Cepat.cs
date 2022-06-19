using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cepat : MonoBehaviour
{
    public Collider2D ball;
    public PowerUpManager manager;
    private float timer;
    public int Despawn;
    public GameObject kanan, kiri;
    // Start is called before the first frame update
    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > Despawn)
        {
            manager.RemovePowerUp(gameObject);
            timer -= Despawn;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision == ball)
        {
            if (ball.GetComponent<BallController>().kanan == true)
            {
                kanan.GetComponent<PaddleController>().powercepet(5);
                manager.RemovePowerUp(gameObject);
                Debug.Log("tembakka");
            }
            else
            {
                kiri.GetComponent<PaddleController>().powercepet(5);
                manager.RemovePowerUp(gameObject);
                Debug.Log("tembakki");
            }
        }
    }
}
