using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public string nomSceneJeu = "Player Test";
    
    public void PlayGame(){
        SceneManager.LoadScene(nomSceneJeu);
    }
    public void QuitGame(){
        Application.Quit();
    }
}
