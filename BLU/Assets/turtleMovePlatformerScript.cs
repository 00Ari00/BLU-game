using UnityEngine;

public class turtleMovePlatformerScript : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public BoxCollider2D groundCheck;
    public float moveSpeed = 5;
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
        VerticalMove();
    }

    void GetInputs() {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }

    void HorizontalMove() {
        if (Mathf.Abs(xInput) > 0) {
            playerRB.linearVelocity = new Vector2(xInput * moveSpeed, playerRB.linearVelocityY);
        }
    }

    void VerticalMove() {
        if (Mathf.Abs(yInput) > 0) {
            playerRB.linearVelocity = new Vector2(playerRB.linearVelocityX, yInput * moveSpeed);
        }
    }

    void CheckGround() {

    }

    void ApplyFriction() {

    }
}
