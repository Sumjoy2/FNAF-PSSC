using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    Camera mainCamera;

    [HideInInspector] public bool atGenerator = false;
    [HideInInspector] public bool isHiding = false;
    [HideInInspector] public bool atDesk = true;

    private void Start()
    {
        mainCamera = Camera.main;
        atDesk = true;
    }

    public void LeftDoor()
    {
        atDesk = false;
        mainCamera.transform.position = new Vector3(-3, 3, 134);
        mainCamera.transform.rotation = Quaternion.Euler(0, -50f, 0);
    }

    public void RightDoor()
    {
        atDesk = false;
        mainCamera.transform.position = new Vector3(51, 1.55f, 180);
        mainCamera.transform.rotation = Quaternion.Euler(0, 35, -7);
    }

    public void CameraDesk()
    {
        atGenerator = false;
        isHiding = false;
        atDesk = true;
        mainCamera.transform.position = new Vector3(38.5f, 4.57f, 138);
        mainCamera.transform.rotation = Quaternion.Euler(3.5f, 0, 0);
    }

    public void Generator()
    {
        atDesk = false;
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
