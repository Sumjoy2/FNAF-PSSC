using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public float flickerInrensity = 0.2f;
    public float flickerspersecond = 3.0f;
    public float speedRandomness = 1.0f;

    private float time;
    private float startingIntensity;
    private Light lights;

    // Start is called before the first frame update
    void Start()
    {
        startingIntensity = lights.intensity;
        if (lights == null) return;
        lights = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        lights.intensity = startingIntensity + Mathf.Sin(time * flickerspersecond) * flickerspersecond;
    }
}
