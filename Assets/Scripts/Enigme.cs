using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enigme : MonoBehaviour
{
    //variables
    public int id;
    public static bool afficher = false;
    public GameObject enigmeUI;
    [SerializeField] private TextMeshProUGUI question;
    [SerializeField] private TextMeshProUGUI a;
    [SerializeField] private TextMeshProUGUI b;
    [SerializeField] private TextMeshProUGUI c;
    [SerializeField] private TextMeshProUGUI d;
    [SerializeField] private TextMeshProUGUI score;


    [SerializeField] private Button A;
    [SerializeField] private Button B;
    [SerializeField] private Button C;
    [SerializeField] private Button D;

    private List<Button> listButton = new List<Button>();

    public SystemeDeVies systemeDeVies;


    private string solution;



    //affiche l'ui de l'enigme avec la question et les réponses selon le fichier "enigmes" et l'id
    public void afficherEnigme()
    {
        enigmeUI.SetActive(true);
        Time.timeScale = 0f;
        afficher = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        string path = "Assets/Scripts/enigmes.txt";
        string line = File.ReadLines(path).Skip(id - 1).Take(1).First();
        List<string> list = line.Split(';').ToList();

         question.text = list[0]; a.text = list[1]; b.text = list[2]; c.text = list[3]; d.text = list[4]; solution = list[5];
         listButton.Add(A); listButton.Add(B); listButton.Add(C); listButton.Add(D);

         //ajoute des listeners aux boutons
        for(int i = 0; i < listButton.Count; i++)
        {
            if (listButton[i].name == solution)
            {
                listButton[i].onClick.AddListener(TaskOnClickReussi);
            }
            else
            {
                listButton[i].onClick.AddListener(TaskOnClickEchec);
            }
        }

        list.Clear();
        
       

    }

    //cache l'ui de l'énigme et enlève les listeners
    public void cacherEnigme()
    {
        enigmeUI.SetActive(false);
        Time.timeScale = 1f;
        afficher = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        RemoveListeners();
        

    }

    //ajoute un point lorsque le joueur selectionne la bonne réponse
    void TaskOnClickReussi()
    {
        int calcul = int.Parse(score.text) + 1;
        score.text = calcul.ToString();
      
        cacherEnigme();
        Destroy(this.gameObject);

    }

    //enlève un point lorsque le joueur selectionne la bonne réponse
    void TaskOnClickEchec()
    {
        cacherEnigme();
        systemeDeVies.pointsDeVies -= 1;
    }

    //"enlève" les listeners
    void RemoveListeners(){
        for(int i = 0; i < listButton.Count; i++)
        {
 
            listButton[i].onClick.RemoveAllListeners();
    
        }

    }



}