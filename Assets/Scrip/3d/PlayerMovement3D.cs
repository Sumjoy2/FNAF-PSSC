using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    Camera mainCamera;
    public bool atGenerator = false;
    public bool isHiding = false;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    public void LeftDoor()
    {
        mainCamera.transform.position = new Vector3(-3, 3, 134);
        mainCamera.transform.rotation = Quaternion.Euler(0, -50f, 0);
    }

    public void RightDoor()
    {
        mainCamera.transform.position = new Vector3(51, 1.55f, 180);
        mainCamera.transform.rotation = Quaternion.Euler(0, 35, -7);
    }

    public void CameraDesk()
    {
        atGenerator = false;
        isHiding = false;
        mainCamera.transform.position = new Vector3(38.5f, 3.55f, 138);
        mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void Generator()
    {
        atGenerator = true;
        mainCamera.transform.position = new Vector3(30, 1.55f, 205);
        mainCamera.transform.rotation = Quaternion.Euler(6, 0, 0);
    }

    public void Hide()
    {
        isHiding = true;
        mainCamera.transform.position = new Vector3(38.5f, 2, 145);
    }
}
