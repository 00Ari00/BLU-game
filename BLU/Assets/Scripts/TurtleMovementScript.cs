using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TurtleMovementScript : MonoBehaviour
{
    public Rigidbody2D turtleRB;
    public float moveSpeed = 3;
    private Vector2 moveDirection;

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
    }

    // This function is called every fixed framerate frane, if MonoBehaviour is enabled
    void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // using .normalized to ensure diagonal movement is not faster than vertical and horizontal movement
        moveDirection = new Vector2(moveX, moveY).normalized;
    }

    void Move()
    {
        turtleRB.linearVelocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
