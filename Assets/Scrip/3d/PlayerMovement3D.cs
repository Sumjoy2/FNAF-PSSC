using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    Camera mainCamera;
    public bool atGenerator = false;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    public void LeftDoor()
    {
        mainCamera.transform.position = new Vector3(-7, 3, 144);
        mainCamera.transform.rotation = Quaternion.Euler(0, 12.28f, 17.11f);
    }

    public void RightDoor()
    {
        mainCamera.transform.position = new Vector3(51, 1.55f, 180);
        mainCamera.transform.rotation = Quaternion.Euler(0, 35, -7);
    }

    public void CameraDesk()
    {
        atGenerator = false;
        mainCamera.transform.position = new Vector3(38.5f, 3.55f, 138);
        mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }

    public void Generator()
    {
        atGenerator = true;
        mainCamera.transform.position = new Vector3(30, 1.55f, 205);
        mainCamera.transform.rotation = Quaternion.Euler(6, 0, 0);
    }
}
