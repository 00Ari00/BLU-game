using UnityEngine;

public class CamMovement : MonoBehaviour
{

    public Rigidbody2D body;
    public float moveSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");

        body.linearVelocity = new Vector2(xInput * moveSpeed, body.linearVelocityY);
    }
}
