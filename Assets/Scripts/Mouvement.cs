using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class Mouvement : MonoBehaviour
{

    //variables
    public CharacterController controller;

    public float speed = 7f;
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
        Vector3 baseSpeed = (transform.right * x + transform.forward * z) * speed;
       

        if (controller.isGrounded)
        {
            moveVelocity = baseSpeed;
         
            //Permet de sauter
            if(Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
                animator.SetBool("Saute", true);
            }

            //permet de courir et de sauter en même temps
            if(Input.GetKey(KeyCode.LeftShift))
            {
                moveVelocity = baseSpeed * 1.5f;
                if (Input.GetButtonDown("Jump"))
                {
                    moveVelocity.y = jumpSpeed;
                    animator.SetBool("Saute", true);
                }
            }

        
        }

        moveVelocity.y += gravity * Time.deltaTime;
        controller.Move(moveVelocity * Time.deltaTime);


        //Animations
      
        bool marche = animator.GetBool("Marche");
        bool cours = animator.GetBool("Cours");
        bool saute = !controller.isGrounded;
        bool veutMarcher = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D); 
        bool veutCourir = Input.GetKey(KeyCode.LeftShift);
       


        if (veutMarcher && !marche)
        {   
            animator.SetBool("Marche", (veutMarcher && !marche));
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
        if (cours && (!veutMarcher || !veutCourir))
        {
            animator.SetBool("Cours", false);
        }
        if (!saute)
        {
            animator.SetBool("Saute", false);
        }
        
    }


}

