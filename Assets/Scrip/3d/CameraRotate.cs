using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float currentRotation = 0.3f;
    public float speed;
    Vector3 A;
    Vector3 B;
    void Start()
    {
        A = transform.eulerAngles + new Vector3(0, currentRotation, 0);
        B = transform.eulerAngles + new Vector3(0, -currentRotation, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float timeering = Mathf.PingPong(Time.time * speed, 1);
        transform.eulerAngles = Vector3.Lerp(A, B, timeering);
    }
}
