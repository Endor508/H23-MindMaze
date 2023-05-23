using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractEnigme : MonoBehaviour
{
    //variables
    private Enigme enigme;
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private Transform objectGrabPointTransform;
    


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (enigme == null)
            {
                //utilise un raycast pour mesurer la distance entre le jouer et l'objet
                float interactDistance = 5f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, interactDistance))
                {
                    //si l'objet est à porter, l'ui s'active lorsque le joueur appuie sur E
                    if (raycastHit.transform.TryGetComponent(out enigme))
                    {
                        enigme.afficherEnigme();
                    }
                }
            }
            //si le joueur rappuie sur E, l'ui s'enlève
            else
            {
                enigme.cacherEnigme();
                enigme = null;
            }
        }
    }
}