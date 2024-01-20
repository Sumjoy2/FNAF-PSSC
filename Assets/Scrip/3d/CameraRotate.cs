using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float currentRotation = 0.3f;
    public float speed;
    Vector3 A;
    Vector3 B;

    public GameObject[] locals;
    int arrayCurrentLocal = 0;
    void Start()
    {
        A = transform.eulerAngles + new Vector3(0, currentRotation, 0);
        B = transform.eulerAngles + new Vector3(0, -currentRotation, 0);
        locals[0] = GameObject.Find("StartLocation");
        locals = GameObject.FindGameObjectsWithTag("CamearLocals");
    }

    // Update is called once per frame
    void Update()
    {
        float timeering = Mathf.PingPong(Time.time * speed, 1);
        transform.eulerAngles = Vector3.Lerp(A, B, timeering);
    }

    public void nextCamera()
    {
        transform.position = locals[arrayCurrentLocal].transform.position;
        if (arrayCurrentLocal == locals.Length)
        {
            arrayCurrentLocal = 0;
        }
        else
        {
            arrayCurrentLocal++;
        }
        
    }

    public void prevCamera()
    {
        transform.position = locals[arrayCurrentLocal].transform.position;
        if (arrayCurrentLocal == 0)
        {
            arrayCurrentLocal = locals.Length;
        }
        else
        {
            arrayCurrentLocal--;
        }
        
    }
}
