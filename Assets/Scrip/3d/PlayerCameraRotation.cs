using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    public float speed = 2.0f;
    public float angle;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, angle, 0);
    }
}
