using System.Collections;
using System.Collections.Generic;
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
        lights = GetComponent<Light>();
        startingIntensity = lights.intensity;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime * (1 - Random.Range(-speedRandomness, speedRandomness)) * Mathf.PI;
        lights.intensity = startingIntensity + Mathf.Sin(time * flickerspersecond) * flickerspersecond;
    }
}
