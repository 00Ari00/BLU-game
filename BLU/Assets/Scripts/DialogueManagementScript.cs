using UnityEngine;
using TMPro;
using System.Collections;

public class DialogueBoxManagementScript : MonoBehaviour
{
    public static DialogueBoxManagementScript _instance;
    public TextMeshProUGUI textComponent;

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

    public void SetAndShowDialogue(string[] message, float textSpeed)
    {
        index = 0;

        gameObject.SetActive(true);
        StartCoroutine(TypeLine(message, textSpeed));

    }

    public void HideDialogue()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }

    public void GoToNextLine(string[] lines, float textSpeed)
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("clicked");
            if (textComponent.text == lines[index])
            {
                NextLine(lines, textSpeed);
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    public IEnumerator TypeLine(string[] lines, float textSpeed)
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    void NextLine(string[] lines, float textSpeed)
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine(lines, textSpeed));
        }
        else
        {
            gameObject.SetActive(false);
            textComponent.text = string.Empty;
        }
    }
}
