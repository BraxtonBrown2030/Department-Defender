using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class MenuButtonScript : MonoBehaviour
{
    public UnityEvent menuButtonEvent;
    public InputActionReference actionReference;


    public void Update()
    {
        
        if(actionReference.action.triggered)
        {
            menuButtonEvent.Invoke();
        }
        
    }
}
