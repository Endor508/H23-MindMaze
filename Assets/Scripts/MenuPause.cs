using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    //variables
    public static bool enPause = false;
    public GameObject pauseMenuUI;
    string nomMainMenu = "StartMenu";
    bool vaAuMainMenu = false;

    //s'occupe de mettre en pause le jeu ou de resumer le jeu lorsque le joueur appuie sur échap
    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if (enPause)
            {
                ResumerPartie();
            }
            else
            {
                MettreEnPause();
            }
        }
    }

    //s'occupe de resumer la partie
    public void ResumerPartie()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        enPause = false;

        if (!vaAuMainMenu)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }

      
    }

    //s'occupe de mettre en pause la partie
    void MettreEnPause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        enPause = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    //permet de retourner au menu
    public void RetournerMainMenu ()
    {
        SceneManager.LoadScene(nomMainMenu);
        vaAuMainMenu = true;
        ResumerPartie();
    }

}
