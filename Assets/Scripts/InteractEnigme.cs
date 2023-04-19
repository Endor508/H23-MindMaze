using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractEnigme : MonoBehaviour
{
    private Enigme enigme;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (enigme == null)
            {
                enigme.afficherEnigme();
            }
        }
    }
}

