using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.XR;

public class VrHandButtonPressBEhavior : MonoBehaviour
{
    public UnityEvent buttonPress;


    public void ButtonPress()
    {
        XRController controller = GetComponent<XRController>();
        
        
        controller.device
        
        
    }


}
