using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.EventSystems;

public class Generator : MonoBehaviour
{
    public float generatorAmount = 500;
    public bool refueling = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        generatorAmount--;
        //if (refueling)

    }

    public void WindUp()
    {
        generatorAmount += 5;
    }
}
