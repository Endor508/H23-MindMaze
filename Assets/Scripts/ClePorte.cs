using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClePorte : MonoBehaviour
{
    public GameObject saPorte;
    

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == saPorte)
        {
            Destroy(this.gameObject);
        }    
    }
}
