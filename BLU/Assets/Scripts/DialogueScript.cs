using UnityEngine;

public class DialogueScript : MonoBehaviour
{

    public string[] message;
    public float textSpeed;

    void Update()
    {
        Debug.Log("runnin");
        DialogueBoxManagementScript._instance.GoToNextLine(message, textSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("hit");
        if (!DialogueBoxManagementScript._instance.gameObject.activeSelf && collision.gameObject.tag == "Player")
        {
            DialogueBoxManagementScript._instance.SetAndShowDialogue(message, textSpeed);
        }
    }
}
