using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
{
    public GameObject textboxPanel;
    public Text messageText; // Or TMP_Text if using TextMeshPro

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textboxPanel.SetActive(false);
   
    }

    public void ShowMessage(string message)
    {
        messageText.text = message;
        textboxPanel.SetActive(true);
    }

    public void HideMessage()
    {
        textboxPanel.SetActive(false);
    }
}
