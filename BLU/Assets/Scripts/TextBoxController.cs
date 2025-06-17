using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxController : MonoBehaviour
{
    public GameObject TextBoxPanel; //Panel with background
    public TMP_Text messageText; //Text
    public float typingSpeed = 0.05f; //Time between letters
    public float displayTime = 2f; //Time to display full message
    private Coroutine typingCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    /*void Start()
    {
        textboxPanel.SetActive(false);
   
    }*/




    public void ShowMessage(string message)
    {
        if (typingCoroutine != null)
        {
            StopCoroutine(typingCoroutine);
           // messageText.text = message;
           // textboxPanel.SetActive(true);
        }
        typingCoroutine = StartCoroutine(TypeText(message));
    }

    public void HideMessage()
    {
        TextBoxPanel.SetActive(false);
    }

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
