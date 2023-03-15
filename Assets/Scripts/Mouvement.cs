using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class Mouvement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 7f;
    //public float rotationSpeed = 90;
    public float gravity = -9.81f;
    public float jumpSpeed = 5;

    Vector3 moveVelocity;

    void Awake()
    {
         controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(controller.isGrounded)
        {
            moveVelocity = (transform.right * x + transform.forward * z) * speed;
         
            
            if(Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
            }
        }

        moveVelocity.y += gravity * Time.deltaTime;
        controller.Move(moveVelocity * Time.deltaTime);
      
    }
}
