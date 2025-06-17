using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelinaTurtleMovement : MonoBehaviour
{
    public Rigidbody2D turtleRB;
    public float moveSpeed = 3;
    public float stopXPosition = 487;
    private bool isMoving = true;
    public TextBoxController textBoxController;
    private bool messageShown = false;

    void Start()
    {
        this.transform.position = new Vector3(35.4f, -19.6f, -4);
        turtleRB.linearVelocity = new Vector2(moveSpeed, 0);
    }

    // This function is called every fixed framerate frane, if MonoBehaviour is enabled
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
                textBoxController.ShowMessage("We've arrived at the reef!");
        }
    }
}
