using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    //Variable
    private Camera _mainCamera;
    public TextBoxController textBoxController;

    
    private void Awake()
    {
        _mainCamera = Camera.main;

        //if the textBoxController hasn't been assigned, find one in the scene
        if (textBoxController == null)
        {
            textBoxController = FindAnyObjectByType<TextBoxController>();
        }
    }

    //When clicked on an object reveal the message
    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        var textTrigger = rayHit.collider.GetComponent<ClickToRevealText>();
        if (textTrigger != null)
        {
            textBoxController.ShowMessage(textTrigger.message);
        }
    }
}