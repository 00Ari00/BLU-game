using UnityEngine;

public class TurtleScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float swimStrength;
    public LogicScript logic;
    public bool turtleIsAlive = true;
    private Rigidbody2D myRigidbody;
    public float upperBound;
    public float lowerBound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && turtleIsAlive == true)
        {
            myRigidBody.linearVelocity = new Vector2(myRigidBody.linearVelocity.x, swimStrength);
        }
        Vector3 pos = transform.position;
        pos.y = Mathf.Clamp(pos.y, lowerBound, upperBound);
        transform.position = pos;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //logic.gameOver();
        //turtleIsAlive = false;

        if (collision.gameObject.CompareTag("Net"))
        {
            turtleIsAlive = false;
            myRigidbody.linearVelocity = Vector2.zero;
            myRigidbody.gravityScale = 0f;
            myRigidbody.constraints = RigidbodyConstraints2D.FreezeAll;
            logic.gameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "TopBoundary" || other.gameObject.name == "BottomBoundary")
        {
            Debug.Log("Hit boundary!");
        }
    }

}
