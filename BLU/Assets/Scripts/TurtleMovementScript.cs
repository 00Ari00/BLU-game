using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovementScript : MonoBehaviour
{
    public Rigidbody2D turtleRigidBody;
    public float turtleWalkSpeed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // not proper way to do movement just experimenting right now
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("body" + turtleRigidBody.linearVelocity);
            turtleRigidBody.linearVelocity = Vector2.up * turtleWalkSpeed;
        } else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("body" + turtleRigidBody.linearVelocity);
            turtleRigidBody.linearVelocity = Vector2.left * turtleWalkSpeed;
        } else if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            turtleRigidBody.linearVelocity = Vector2.right * turtleWalkSpeed;
        }
    }
}
