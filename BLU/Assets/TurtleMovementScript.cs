using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMovementScript : MonoBehaviour
{
    public Rigidbody2D turtleRigidBody;
    public float turtleWalkSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("body" + turtleRigidBody.linearVelocity);
            turtleRigidBody.linearVelocity = Vector2.up * turtleWalkSpeed;
        }
    }
}
