using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClePorte : MonoBehaviour
 {
    [SerializeField] private Animation ouverturePorte;
    


    public void OuvrirPorte(){
        ouverturePorte.Play();
        Destroy(this.gameObject);


    }
}
