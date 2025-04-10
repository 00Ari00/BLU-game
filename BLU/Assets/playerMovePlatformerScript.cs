using System;
using UnityEngine;

public class playerMovePlatformerScript : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public BoxCollider2D groundCheck;
    public bool grounded;
    public float moveSpeed = 5;
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
        yInput = Input.GetAxis("Vertical");
    }

    void HorizontalMove() {
        if (Mathf.Abs(xInput) > 0) {
            playerRb.linearVelocity = new Vector2(xInput * moveSpeed, playerRb.linearVelocityY);
        }
    }

    void VerticalMove() {
        if (Mathf.Abs(yInput) > 0) {
            playerRb.linearVelocity = new Vector2(playerRb.linearVelocityX, yInput * moveSpeed);
        }
    }

    void CheckGround() {
    }

    void ApplyFriction() {

    }
}
