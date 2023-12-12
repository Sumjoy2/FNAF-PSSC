using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmymoving : MonoBehaviour
{
    //int a = 25;
    int ticky;
   // int x;
    int y;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        ticky++;
        if (ticky==25)
        {
         y = Random.Range(0,20);
         Debug.Log(y);
         ticky = 0;
        }
    }
}