using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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

    //Animateur
    public Animator animator;

    void Awake()
    {
        controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
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


        //Animations
        bool marche = animator.GetBool("Marche");
        bool cours = animator.GetBool("Cours");
        bool veutMarcher = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S);
        bool veutCourir = Input.GetKey(KeyCode.LeftShift);


        if (veutMarcher && !marche)
        {   
            animator.SetBool("Marche", true);
        }
        if (marche && !veutMarcher)
        {
            animator.SetBool("Marche", false);
        }
        if(!cours && (veutMarcher && veutCourir))
        {
            animator.SetBool("Cours", true);
        }
        if (cours && (!veutMarcher || !veutCourir))
        {
            animator.SetBool("Cours", false);
        }

      
    }
}
