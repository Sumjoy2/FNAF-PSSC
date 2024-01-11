using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    public float speed = 2.0f;
    public float angle;
    public float cutOffAngle;
    public Canvas deskButtons;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        angle += speed * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, angle, 0);
        if (transform.rotation.eulerAngles.y >= cutOffAngle)
        {
            deskButtons.gameObject.SetActive(false);
        }
        else
        {
            deskButtons.gameObject.SetActive(true);
        }
    }
}
