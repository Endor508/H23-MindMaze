using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerOpenDoor : MonoBehaviour
{
    //Variables
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask keyLayerMask;
    [SerializeField] private TextMeshProUGUI score;
    [SerializeField] private GameObject key;


    // Update is called once per frame
    void Update()
    //utilise un raycast pour mesurer la distance entre la clé et le joueur pour savoir si la clé est assez proche pour être utlisée
    {
        if (Input.GetKeyDown(KeyCode.E)){
            float keyDistance = 5f;
            if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, keyDistance, keyLayerMask)){
               if(raycastHit.transform.TryGetComponent(out ClePorte clePorte)){
                clePorte.OuvrirPorte();
               }
            }
        }

        //si le score est égale à 5, la clé apparait
        int scoreInt = int.Parse(score.text);
        if(scoreInt >= 5) 
        {
            

            if (!key.IsDestroyed())
            {
                key.SetActive(true);
            }
        }
    }
}
