using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode upKey;
    public KeyCode downKey;
    public int speed,tempspeed;
    private Rigidbody2D rig;
    public Vector2 size,ogsize;
    bool psize = false, pspeed = false;
    float timerp, timers;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        tempspeed = speed * 2;
        size = new Vector3(this.transform.localScale.x, this.transform.localScale.y * 2);
        ogsize = new Vector3(this.transform.localScale.x, this.transform.localScale.y);
    }

    private void Update()
    {
        if (pspeed == true )
        {
            timerp -= Time.deltaTime;
            MoveObject(GetInputtemp());
            Debug.Log(timerp);
        }
        else
        MoveObject(GetInput());

        
        if (psize == true)
        {
            timers -= Time.deltaTime;
            this.transform.localScale = size;
            Debug.Log(timers);
        }
        else
            this.transform.localScale = ogsize;


        if (timers <= 0)
        {
            psize = false;
        }

        if (timerp <= 0)
        {
            pspeed = false;
        }
    }

    private Vector2 GetInput()
    {

        if (Input.GetKey(upKey))
        {
            Debug.Log("Gerak euy: " + speed);
            return Vector2.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            Debug.Log("Gerak euy: " + speed);
            return Vector2.down * speed;

        }

        return Vector2.zero;
    }


    private Vector2 GetInputtemp()
    {

        if (Input.GetKey(upKey))
        {
            Debug.Log("Gerak euy: " + tempspeed);
            return Vector2.up * tempspeed;
        }
        else if (Input.GetKey(downKey))
        {
            Debug.Log("Gerak euy: " + tempspeed);
            return Vector2.down * tempspeed;

        }

        return Vector2.zero;
    }


    public void powergede(float f)
    {
        psize = true;
        timers += f;
        Debug.Log("Powergede");
    }

    public void powercepet(float f)
    {
        pspeed = true;
        timerp += f;
        Debug.Log("Powercepet");
    }

    private void MoveObject(Vector2 movement)
    {

        // Debug.Log("Gerak euy: " + movement);
        rig.velocity = movement;
    }



}
