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
        StartCoroutine(Roll(timer - night));
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (rand > level)
        {
            return;
        }
        else if (rand <= level)
        {
            MoveForward();
            rand = 21;
            
        }
    }

    public void MoveForward()
    {
        //some code here
        transform.position += new Vector3 (rand, 0 ,0);
        StartCoroutine(Roll(timer - night));
    }

    IEnumerator Roll(float time)
    {
        yield return new WaitForSeconds(time);
        rand = Random.Range(0, levelMax);
    }
}