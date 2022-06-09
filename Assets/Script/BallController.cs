using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 resetPosition;
    public Vector2 speed;
    private Rigidbody2D rig;
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        rig.velocity = speed;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void ResetBall()
    {
        speed = new Vector2(Random.Range(-10, 10), Random.Range(-10, -10));
        rig.velocity = speed;
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);

    }
}
