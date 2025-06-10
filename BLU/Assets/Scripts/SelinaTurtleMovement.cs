using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelinaTurtleMovement : MonoBehaviour
{
    public Rigidbody2D turtleRB;
    public float moveSpeed = 3;

    // Update is called once per frame
    void Update()
    {
    }

    // This function is called every fixed framerate frane, if MonoBehaviour is enabled
    void FixedUpdate()
    {
        turtleRB.linearVelocity = new Vector2(moveSpeed, turtleRB.linearVelocity.y);
    }
}
