using UnityEngine;

public class TurtleScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float swimStrength;
    public LogicScript logic;
    public bool turtleIsAlive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && turtleIsAlive == true)
        {
            myRigidBody.linearVelocity = new Vector2(myRigidBody.linearVelocity.x, swimStrength);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        turtleIsAlive = false;

    }

}
