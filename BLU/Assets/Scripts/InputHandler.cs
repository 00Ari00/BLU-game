using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    private Camera _mainCamera;
    public TextBoxController textBoxController;


    private void Awake()
    {
        _mainCamera = Camera.main;
        if (textBoxController == null)
        {
        textBoxController = FindObjectOfType<TextBoxController>();
        }
    }

    public void OnClick(InputAction.CallbackContext context)
    {
        if (!context.started) return;

        var rayHit = Physics2D.GetRayIntersection(_mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue()));
        if (!rayHit.collider) return;

        Debug.Log(rayHit.collider.gameObject.name);

        var textTrigger = rayHit.collider.GetComponent<ClickToRevealText>();
        if (textTrigger != null)
        {
            textBoxController.ShowMessage(textTrigger.message);
        }
    }
}