using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject pauseMenuUI;
    string nomMainMenu = "StartMenu";
    bool vaAuMainMenu = false;


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

    void MettreEnPause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        enPause = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    public void RetournerMainMenu ()
    {
        SceneManager.LoadScene(nomMainMenu);
        vaAuMainMenu = true;
        ResumerPartie();
    }

}
