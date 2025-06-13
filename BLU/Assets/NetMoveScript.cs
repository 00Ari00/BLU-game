using UnityEngine;

public class NetMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -20;
    public float floatStrength;
    public float floatSpeed;
    public float originalY;
    private float floatOffset;
    private LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        originalY = transform.position.y;
        floatOffset = Random.Range(0f, 2f * Mathf.PI);
    }

    // Update is called once per frame
    void Update()
    {

        if (!logic.isGameOver)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            float newY = originalY + Mathf.Sin(Time.time * floatSpeed + floatOffset) * floatStrength;
            transform.position = new Vector3(transform.position.x, newY, transform.position.z);

        }

        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
