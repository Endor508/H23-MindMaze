using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{


    public Animation porte;
    bool porteOuverte = false;
    public GameObject saCle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
