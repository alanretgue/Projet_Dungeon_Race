using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = 14.81f;
    public Transform groundCheck;
    public float groundDistance = 1f;
    public LayerMask groundMask;

    public Vector3 velocity;
    bool isgrounded;
    public float jumpforce = 5.0f;

    private void Start()
    {
        
    }


    // Jump & Gravity : checked
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isgrounded == false)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        else
        {           
            velocity.y = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = jumpforce;
            }
        }

        //Moove code : checked

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
