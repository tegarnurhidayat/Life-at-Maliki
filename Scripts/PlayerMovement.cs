using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;
    public Rigidbody2D rb;
    public Animator animator;

    private Vector2 moveDirection;

    public Joystick joystick;

    public VectorValue startingPosition;

    public static bool canMove = true;

    void Start()
    {
        transform.position = startingPosition.initialValue;
    }

    void Update()
    {
        if (canMove == true)
        {
            processInputs();
        }
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    void processInputs()
    {
        float joystickX = joystick.Horizontal;
        float joystickY = joystick.Vertical;
        // float movementX = Input.GetAxisRaw("Horizontal");
        // float movementY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(joystickX, joystickY).normalized;
        // moveDirection = new Vector2(movementX, movementY).normalized;
        if(moveDirection != Vector2.zero)
        {
            animator.SetFloat("Horizontal", joystickX);
            animator.SetFloat("Vertical", joystickY);
            animator.SetFloat("Speed", moveDirection.sqrMagnitude);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
        
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * movementSpeed, moveDirection.y * movementSpeed);
    }

}
