using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPause : MonoBehaviour
{
    public static bool enPause = false;
    public GameObject pauseMenuUI;


    void Update(){
        Debug.Log(enPause);
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

    void ResumerPartie()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        enPause = false;
        Cursor.visible = false;
    }

    void MettreEnPause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        enPause = true;
        Cursor.visible = true;
    }

}
