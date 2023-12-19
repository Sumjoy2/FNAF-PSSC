using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOOOOOOR : MonoBehaviour
{
    public bool isActive;
    public Transform Upper;
    public Transform Downper;
    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isActive == true)
        {
            transform.position = Downper.position;
        }
        if (isActive == false) 
        {
            transform.position = Upper.position;
        }
        //53.36, 2.34, 184.07
    }
    public void IsOpen()
    {
        isActive = !isActive;
    }
}
