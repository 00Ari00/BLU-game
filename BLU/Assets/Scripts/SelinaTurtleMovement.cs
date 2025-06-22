using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class SelinaTurtleMovement : MonoBehaviour
{
    //Variables
    public Rigidbody2D turtleRB;
    public float moveSpeed = 3;
    public float stopXPosition = 487;
    private bool isMoving = true;
    public TextBoxController textBoxController;
    private bool messageShown = false;
    private bool hasStarted = false;

    //Starting position when game is starting
    void Start()
    {
        this.transform.position = new Vector3(35.4f, -19.6f, -4);

        //Starting message
        if (textBoxController != null)
        {
            textBoxController.ShowMessage("Find the sea creatures and learn about them. Click anywhere to start the journey!");
        }

    }

    //Starting game and moving turtle when player starts
    void Update()
    {
        if (!hasStarted && Mouse.current.leftButton.wasPressedThisFrame)
        {
            hasStarted = true;
            isMoving = true;
            textBoxController.HideMessage();
            turtleRB.linearVelocity = new Vector2(moveSpeed, 0);
        }
    }

    //Moving turtle and setting a boundary for the ending line
    void FixedUpdate()
    {
        if (isMoving && textBoxController != null && !textBoxController.TextBoxPanel.activeSelf)
        {
            turtleRB.linearVelocity = new Vector2(moveSpeed, turtleRB.linearVelocity.y);
        }

        if (transform.position.x >= stopXPosition && !messageShown)
        {
            turtleRB.linearVelocity = Vector2.zero;
            isMoving = false;
            messageShown = true;

            if (textBoxController != null)
            {
                textBoxController.ShowMessage("We've arrived at the reef!");
            }
        }

        if (!isMoving)
        {
            turtleRB.linearVelocity = Vector2.zero;
        }
    }
}
