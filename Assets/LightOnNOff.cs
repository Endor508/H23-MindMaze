using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOnNOff : MonoBehaviour
{
    Light myLight;
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.E))
        {
            myLight.enabled = !myLight.enabled;
        }

    }
}
