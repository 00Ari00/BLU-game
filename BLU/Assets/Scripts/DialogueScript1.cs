using UnityEngine;

public class DialogueScript1 : MonoBehaviour
{
    public string[] message;
    public float textSpeed;

    void Update()
    {
        DialogueManagementScript._instance.GoToNextLine();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        if (!DialogueManagementScript._instance.gameObject.activeSelf && collision.gameObject.tag == "Player")
        {
            DialogueManagementScript._instance.SetAndShowDialogue(message, textSpeed);
        }
    }
}
