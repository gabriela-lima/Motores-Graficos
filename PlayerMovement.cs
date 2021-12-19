using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private CharacterController controller;

    public GameObject flashlight;

    public float speed = 5f;
    public float gravity = -19f;
    public float jumpHeight = 0.5f;

    public Transform groundCheck;
    public float groundDistance = 0.65f;
    public LayerMask groundMask;

    bool isActive = true;
    
    Vector3 velocity;
    bool isGrounded;
    // Update is called once per frame

    void Start() 
    {
        controller = this.GetComponent<CharacterController>();
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

       float x = Input.GetAxis("Horizontal");
       float z = Input.GetAxis("Vertical");

       Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.F))
        {
            isActive = !isActive;
            flashlight.SetActive(isActive);
        }
    }
}
