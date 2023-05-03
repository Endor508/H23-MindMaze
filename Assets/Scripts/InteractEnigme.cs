using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractEnigme : MonoBehaviour
{
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
                float interactDistance = 5f;
                if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, interactDistance))
                {
                    if (raycastHit.transform.TryGetComponent(out enigme))
                    {
                        enigme.afficherEnigme();
                    }
                }
            }
            else
            {
                enigme.cacherEnigme();
                enigme = null;
            }
        }
    }
}