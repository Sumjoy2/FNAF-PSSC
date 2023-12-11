using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Camera mainCamera;

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
        mainCamera.transform.position = new Vector3(60, 1.55f, 175);
    }

    public void CameraDesk()
    {
        mainCamera.transform.position = new Vector3(38.5f, 3.55f, 138);
        mainCamera.transform.rotation = Quaternion.Euler(0, 0, 0);
    }
}
