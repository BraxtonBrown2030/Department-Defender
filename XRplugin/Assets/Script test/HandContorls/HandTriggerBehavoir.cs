using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class HandTriggerBehavoir : MonoBehaviour
{
    public InputActionReference inputAction;
    public UnityEvent triggerEvent, exitEvent;
    
        void Update()
        {

            if (inputAction.action.ReadValue<float>() > 0.1f)
            {
                triggerEvent.Invoke();

            }
            else
            {
                exitEvent.Invoke();
            }
         
        }
    


}
