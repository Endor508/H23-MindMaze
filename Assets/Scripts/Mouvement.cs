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
        Vector3 baseSpeed = (transform.right * x + transform.forward * z) * speed;


        if (controller.isGrounded)
        {
            moveVelocity = baseSpeed;


            if (Input.GetButtonDown("Jump"))
            {
                moveVelocity.y = jumpSpeed;
                animator.SetBool("Saute", true);



            }

            if (Input.GetKey(KeyCode.LeftShift))
            {
                moveVelocity = baseSpeed * 1.5f;
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
            animator.SetBool("Marche", true);
        }
        if (marche && !veutMarcher)
        {
            animator.SetBool("Marche", false);
        }
        if (!cours && (veutMarcher && veutCourir))
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

