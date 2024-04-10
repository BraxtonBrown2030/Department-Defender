using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MenuButtonScript : MonoBehaviour
{
    
    public UnityEvent menuButtonEvent;
    public InputActionReference actionReference;

    private void OnEnable()
    {
        // Subscribe to the action's performed event
        actionReference.action.performed += OnActionPerformed;
    }

    private void OnDisable()
    {
        // Unsubscribe from the action's performed event
        actionReference.action.performed -= OnActionPerformed;
    }

    private void OnActionPerformed(InputAction.CallbackContext context)
    {
        // The action has been performed, invoke the event
        menuButtonEvent.Invoke();
    }
}
