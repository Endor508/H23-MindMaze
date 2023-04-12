using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour {

    public GameObject clePorte;
    
    public Animation ouverturePorte;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == clePorte) {
            ouverturePorte.Play();
            Destroy(clePorte);
        }
        
    }
}
