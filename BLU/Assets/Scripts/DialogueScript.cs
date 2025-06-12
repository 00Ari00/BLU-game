using UnityEngine;

public class DialogueScript : MonoBehaviour
{

    public string[] message;
    public float textSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Update()
    {
        DialogueBoxManagementScript._instance.GoToNextLine(message, textSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!DialogueBoxManagementScript._instance.gameObject.activeSelf && collision.gameObject.tag == "Player")
        {
            DialogueBoxManagementScript._instance.SetAndShowDialogue(message, textSpeed);
        }
    }
}
