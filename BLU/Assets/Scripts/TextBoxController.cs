using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxController : MonoBehaviour
{
    //Variables
    public GameObject TextBoxPanel; //Panel with background
    public TMP_Text messageText; //Text
    public float typingSpeed = 0.01f; //Time between letters
    public float displayTime = 2f; //Time to display full message
    private Coroutine typingCoroutine;

    void Start()
    {
        TextBoxPanel.SetActive(false);
    }

    //Displaying a message
    public void ShowMessage(string message)
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
        }
        typingCoroutine = StartCoroutine(TypeText(message));
    }

    //Hiding the message
    public void HideMessage()
    {
        TextBoxPanel.SetActive(false);
    }

    //Typing the text letter by letter and displaying it for a couple of seconds
    private IEnumerator TypeText(string message)
    {
        TextBoxPanel.SetActive(true);
        messageText.text = "";

        foreach (char letter in message.ToCharArray())
        {
            messageText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }

        yield return new WaitForSeconds(displayTime);

        messageText.text = "";
        TextBoxPanel.SetActive(false);
    }
}
