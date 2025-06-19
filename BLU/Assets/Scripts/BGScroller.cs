using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public float resetY = 14.64f; 
    public float startY = 14.64f;

    void Update()
{
    if (DodgeManager.Instance != null && DodgeManager.Instance.isGameOver) return;

    transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);

    if (transform.position.y <= -14.64f)
    {
        transform.position += new Vector3(0, 2 * 14.64f, 0);
    }
}

}
