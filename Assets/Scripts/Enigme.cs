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

    public string Question { get => question; set => question = value; }
    public string A { get => a; set => a = value; }
    public string B { get => b; set => b = value; }
    public string C { get => c; set => c = value; }
    public string D { get => d; set => d = value; }

    void Awake()
    {
        string path = "Assets/Scripts/enigme.txt";
        string line = File.ReadLines(path).Skip(id-1).Take(1).First();
        List<string> list = line.Split(';').ToList();
        Question = list[0];
        A = list[1]; B = list[2]; C = list[3]; D = list[4]; solution = list[5];

    }

    public void afficherEnigme()
    {
        enigmeUI.SetActive(true);
        Time.timeScale = 0f;
        afficher = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void cacherEnigme()
    {
        enigmeUI.SetActive(false);
        Time.timeScale = 1f;
        afficher = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        //faire les events
    }


}
