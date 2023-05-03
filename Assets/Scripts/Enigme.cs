using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Enigme : MonoBehaviour
{
    public int id;
    public static bool afficher = false;
    public GameObject enigmeUI;
    [SerializeField] private TextMeshProUGUI question;
    [SerializeField] private TextMeshProUGUI a;
    [SerializeField] private TextMeshProUGUI b;
    [SerializeField] private TextMeshProUGUI c;
    [SerializeField] private TextMeshProUGUI d; 
    private string solution;

    public TextMeshProUGUI Question { get => question; set => question = value; }
    public TextMeshProUGUI A { get => a; set => a = value; }
    public TextMeshProUGUI B { get => b; set => b = value; }
    public TextMeshProUGUI C { get => c; set => c = value; }
    public TextMeshProUGUI D { get => d; set => d = value; }

    void Start()
    {
        string path = "Assets/Scripts/enigmes.txt";
        string line = File.ReadLines(path).Skip(id - 1).Take(1).First();
        List<string> list = line.Split(';').ToList();

        question.text = list[0]; a.text = list[1]; b.text = list[2]; c.text = list[3]; d.text = list[4];





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