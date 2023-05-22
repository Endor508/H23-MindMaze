using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    public string nomSceneJeu = "MathV.2";
    public string nomSceneJeu1 = "StartingScene";

   
    public void PlayHistoire(){
        SceneManager.LoadScene(nomSceneJeu1);
    }

   public void PlayMath(){
        SceneManager.LoadScene(nomSceneJeu);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
