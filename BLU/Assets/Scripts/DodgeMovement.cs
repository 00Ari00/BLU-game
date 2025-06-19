using UnityEngine;

public class DodgeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Move left/right with arrow keys or A/D
        float moveX = Input.GetAxis("Horizontal");
        transform.position += new Vector3(moveX, 0, 0) * moveSpeed * Time.deltaTime;
    }

   void OnTriggerEnter2D(Collider2D other)
{
    if (other.CompareTag("Enemy"))
    {
        DodgeManager.Instance.RegisterHit();

        // Reset the enemy's position instead of destroying it
        other.GetComponent<DodgeEnemy>().ResetPosition();
    }
}


}
