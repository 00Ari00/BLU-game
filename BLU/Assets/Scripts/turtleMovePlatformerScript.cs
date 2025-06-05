using System;
using UnityEngine;

public class turtleMovePlatformerScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public BoxCollider2D groundCheck;
    public LayerMask groundMask;
    public float moveSpeed = 5;
    public float jumpSpeed = 8;
    [Range(0f, 1f)]
    public float groundDecay = 0.5f;
    public bool grounded;
    private float xInput;
    private float yInput;

    // Update is called once per frame
    void Update()
    {
        GetInputs();
        HorizontalMove();
    }

    void FixedUpdate()
    {
        CheckGround();
        ApplyFriction();
        VerticalMove();
    }

    void GetInputs() {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Jump");

        Debug.Log($"{xInput} {yInput}");

    }

    void HorizontalMove() {
        if (Mathf.Abs(xInput) > 0) {
            playerRB.linearVelocity = new Vector2(xInput * moveSpeed, playerRB.linearVelocityY);
        }
    }

    void VerticalMove() {
        if (Mathf.Abs(yInput) > 0 && grounded) {
            playerRB.linearVelocity = new Vector2(playerRB.linearVelocityX, yInput * jumpSpeed);
        }
    }

    void CheckGround() {
        grounded = Physics2D.OverlapAreaAll(groundCheck.bounds.min, groundCheck.bounds.max, groundMask).Length > 0;
    }

    void ApplyFriction() {
        if (grounded && xInput == 0 && yInput == 0) {
            playerRB.linearVelocity *= groundDecay;
        }
    }
}
