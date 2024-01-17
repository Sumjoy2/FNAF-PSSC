using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    //For Camera Follow Mouse
    public float speed = 2.0f;
    public float angle;
    //To make the UI disapear at certain rotation
    public float cutOffAngleLow;
    public float cutOffAngleHigh;
    public Canvas deskButtons;
    
    // Update is called once per frame
    void Update()
    {
        //Rotates camera's y rotation with mouse
        angle += speed * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, angle, 0);

        //does fancy to make the UI disapear 
        float difference = Mathf.DeltaAngle (0, transform.eulerAngles.y);
        if (difference > cutOffAngleLow && difference < cutOffAngleHigh)
        {
            deskButtons.gameObject.SetActive(true);
        }
        else
        {
            deskButtons.gameObject.SetActive(false);
        }
    }
}
