using UnityEngine;

public class SelinaMouseClickOnObject : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Debug.Log("GameObjecct clicked: " + gameObject.name);

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }

    private void OnMouseUp()
    {

        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
