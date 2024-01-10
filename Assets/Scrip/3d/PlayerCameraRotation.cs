using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraRotation : MonoBehaviour
{
    public float speed = 2.0f;
    public float angle;
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
        if (Mathf.Abs(transform.rotation.y) >= 140) // Needs Fixed Not Working
        {
            deskButtons.gameObject.SetActive(false);
        }
        else
        {
            deskButtons.gameObject.SetActive(true);
        }
    }
}
