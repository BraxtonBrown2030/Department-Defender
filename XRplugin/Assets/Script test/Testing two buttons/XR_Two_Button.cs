using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class XR_Two_Button : MonoBehaviour
{

    public UnityEvent menuButtonEvent;
    public InputActionReference actionReference1;
    public InputActionReference actionReference2;

    private bool action1Performed = false;
    private bool action2Performed = false;

    private void OnEnable()
    {
        // Subscribe to the action's performed event
        actionReference1.action.performed += OnActionPerformed1;
        actionReference2.action.performed += OnActionPerformed2;
    }

    private void OnDisable()
    {
        // Unsubscribe from the action's performed event
        actionReference1.action.performed -= OnActionPerformed1;
        actionReference2.action.performed -= OnActionPerformed2;
    }

    private void OnActionPerformed1(InputAction.CallbackContext context)
    {
        // The first action has been performed
        action1Performed = true;
        CheckBothActionsPerformed();
    }

    private void OnActionPerformed2(InputAction.CallbackContext context)
    {
        // The second action has been performed
        action2Performed = true;
        CheckBothActionsPerformed();
    }

    private void CheckBothActionsPerformed()
    {
        if (action1Performed && action2Performed)
        {
            // Both actions have been performed, invoke the event
            menuButtonEvent.Invoke();
            // Reset the actions
            action1Performed = false;
            action2Performed = false;
        }
    }
}