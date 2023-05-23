using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClePorte : MonoBehaviour
 {
    //variables
    [SerializeField] private Animation ouverturePorte;
    

    //active l'animation d'ouverture de la porte et detruit la clé
    public void OuvrirPorte(){
        ouverturePorte.Play();
        Destroy(this.gameObject);


    }
}
