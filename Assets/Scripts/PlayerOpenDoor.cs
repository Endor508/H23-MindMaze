using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOpenDoor : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask keyLayerMask;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            float keyDistance = 5f;
            if(Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, keyDistance, keyLayerMask)){
               if(raycastHit.transform.TryGetComponent(out ClePorte clePorte)){
                clePorte.OuvrirPorte();
               }
            }
        }
    }
}
