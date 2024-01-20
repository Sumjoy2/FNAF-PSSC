using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Materls : MonoBehaviour
{
    public float flickerInrensity = 0.2f;
    public float flickerspersecond = 3.0f;
    public float speedRandomness = 1.0f;

    private float time;
    private float startingIntensity;
    public GameObject material;

    // Start is called before the first frame update
    void Start()
    {
        material = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        material.GetComponent<Renderer>().material.SetColor("_EmissiveColor", Color.white * (startingIntensity + Mathf.Sin(time * flickerspersecond)) * flickerspersecond);
    }
}
