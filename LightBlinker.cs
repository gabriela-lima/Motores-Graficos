using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlinker : MonoBehaviour
{
    private Light lights;
    private bool isEnabled;
    public float counter = 1f;

    void Start()
    {
        lights = this.GetComponent<Light>();
    }

    void Update()
    {
        counter -= Time.deltaTime;
        if (counter < 0 && !isEnabled)
        {
            lights.enabled = !isEnabled;
            isEnabled = !isEnabled;
            counter = 1f;
        }
        else if (counter < 0 && isEnabled)
        {
            lights.enabled = !isEnabled;
            isEnabled = !isEnabled;
            counter = 1f;
        }
    }

}
