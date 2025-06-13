using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelinaTurtleMovement : MonoBehaviour
{
    public Rigidbody2D turtleRB;
    public float moveSpeed = 3;
    public float stopXPosition = 487;
    private bool isMoving = true;
    
    void Start()
    {
     this.transform.position = new Vector3 (-38.46f, -22.52f, -4);
    }
    
    // Update is called once per frame
    void Update()
    {
    }

    // This function is called every fixed framerate frane, if MonoBehaviour is enabled
    void FixedUpdate()
    {



        if (isMoving) {

            turtleRB.linearVelocity = new Vector2(moveSpeed, turtleRB.linearVelocity.y);
        } 

        if (transform.position.x >= stopXPosition) {
            turtleRB.linearVelocity = Vector2.zero;
            isMoving = false;
        }
    }
}
