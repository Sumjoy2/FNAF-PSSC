using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmymoving : MonoBehaviour
{
    public int level;
    public int levelMax;
    public int night;
    int rand;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(Roll(timer - night));
        if (rand > level)
        {
            return;
        }
        else if (rand <= level)
        {
            MoveForward();
        }
    }

    public void MoveForward()
    {
        //some code here
        Debug.Log("moved, Random Number: " +  rand);
    }

    IEnumerator Roll(float time)
    {
        yield return new WaitForSeconds(time);
        rand = Random.Range(0, levelMax);
    }
}