using UnityEngine;

public class EndLevelScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneControllerScript._instance.ReturnToMainScene();
        }
    }
}
