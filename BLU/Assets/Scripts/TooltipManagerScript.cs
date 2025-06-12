using UnityEngine;
using TMPro;

public class TooltipManagerScript : MonoBehaviour
{
    public static TooltipManagerScript _instance;
    public TextMeshProUGUI textComponent;

    private void Awake()
    {
        /*
            checking if there already is a TooltipManagerScript instance that exists 
            in the scene, then the check happens
        */
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetAndShowToolTip(string message)
    {
        gameObject.SetActive(true);
        textComponent.text = message;
    }

    public void HideToolTip()
    {
        gameObject.SetActive(false);
        textComponent.text = string.Empty;
    }
}
