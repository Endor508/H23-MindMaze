using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{

    //variables
    public Animation porte;
    bool porteOuverte = false;
    public GameObject saCle;
    
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.E) && !porteOuverte) 
        {
           porte.Play();
           porteOuverte=true;
           Destroy(saCle);
        }
    }
}
