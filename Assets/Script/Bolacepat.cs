using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bolacepat : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D ball;
    public float magnitude;
    public PowerUpManager manager;
    private float timer; 
    public int Despawn;

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
            ball.GetComponent<BallController>().ActivatePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        }
    }
}
