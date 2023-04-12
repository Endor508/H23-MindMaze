using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClePOrte : MonoBehaviour
{
    public GameObject porte;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == porte)
        {
            Destroy(porte);
        }
        
    }
}
