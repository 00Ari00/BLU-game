using UnityEngine;

public class Tooltip : MonoBehaviour
{
    public string message;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check the tag of object entering 
        if (collision.gameObject.tag == "Player")
        {
            TooltipManagerScript._instance.SetAndShowToolTip(message);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            TooltipManagerScript._instance.HideToolTip();
        }
    }

}
