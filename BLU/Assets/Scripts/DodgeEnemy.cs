using UnityEngine;

public class DodgeEnemy : MonoBehaviour
{
    public float speed = 4f;
    public float resetY = 6f;
    public float minX = -7f;
    public float maxX = 7f;

    void Update()
    {
        if (DodgeManager.Instance.isGameOver) return;
        // Move downward
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // If offscreen at bottom, reset position to top
        if (transform.position.y < -6f)
        {
            ResetPosition();
        }
    }

    public void ResetPosition()
    {
        float randomX = Random.Range(minX, maxX);
        transform.position = new Vector3(randomX, resetY, 0);
    }
}
