using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12f;
    public float gravity = 9.81f;
    public Transform groundCheck;
    public float groundDistance = 1f;
    public LayerMask groundMask;
    public float jumpheight = 3f;

    public Vector3 velocity;
    bool isgrounded;

    private void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        isgrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isgrounded == false)
        {
            velocity.y -= gravity * Time.deltaTime;
        }
        else
        {           
            velocity.y = 0f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        controller.Move(velocity * Time.deltaTime);
    }
}
