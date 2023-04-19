using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Enigme : MonoBehaviour
{
    public int id;
    public static bool afficher = false;
    public GameObject enigmeUI;
    private string question;
    private string a;
    private string b;
    private string c;
    private string d;
    private string solution;

    
    void Awake()
    {
        string path = "Assets/Scripts/enigme.txt";
        //StreamReader enigme = new StreamReader(path);
        string line = File.ReadLines(path).Skip(id-1).Take(1).First();
        List<string> list = line.Split(';').ToList();
        question = list[0];
        a = list[1]; b = list[2]; c = list[3]; d = list[4]; solution = list[5];

    }

    void afficherEnigme()
    {
        enigmeUI.SetActive(true);
        Time.timeScale = 0f;
        afficher = true;
        Cursor.visible = true;
    }

    void cacherEnigme()
    {
        enigmeUI.SetActive(false);
        Time.timeScale = 1f;
        afficher = false;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(afficher == true)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                cacherEnigme();
            }
        }

        //faire les events
    }
}
