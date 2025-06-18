using UnityEngine;
using TMPro;
using System.Collections;

public class DialogueManagementScript : MonoBehaviour
{
    public static DialogueManagementScript _instance;
    public TextMeshProUGUI textComponent;

    private string[] message;
    private float textSpeed;

    private int index;

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    void Start()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }

    public void SetAndShowDialogue(string[] lines, float speed)
    {
        index = 0;
        message = lines;
        textSpeed = speed;

        gameObject.SetActive(true);
        StartCoroutine(TypeLine());

    }

    public void HideDialogue()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }

    public void GoToNextLine()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            if (textComponent.text.Equals(message[index]))
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = message[index];
            }
        }
    }

    public IEnumerator TypeLine()
    {
        foreach (char c in message[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine()
    {
        if (index < message.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            textComponent.text = string.Empty;
            Debug.Log(textComponent.text);
            gameObject.SetActive(false);
        }
    }
}
