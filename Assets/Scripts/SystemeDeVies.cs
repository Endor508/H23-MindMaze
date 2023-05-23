using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SystemeDeVies : MonoBehaviour
{
    //initialization des variables
    public int pointsDeVies;
    public Image[] coeurs;

    void Update(){
        //affiche et enlève des coeurs
        for(int i = 0; i < coeurs.Length; i++)
        if(i < pointsDeVies){
            coeurs[i].enabled = true;
        } else {
            coeurs[i].enabled = false;
        }

        //si le player n'a plus de vie, le jeu retourne au menu principal
        if (pointsDeVies <= 0){
            SceneManager.LoadScene("StartMenu");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }



    }

}
