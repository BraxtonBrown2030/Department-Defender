using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class VrButtonPush : MonoBehaviour
{
    
    public InputActionReference inputActionReference;
    private XRController controller;
    public GameObject hand;
    
    void Start()
    {
        controller = hand.GetComponent<XRController>();

    }
    
    void Update()
    {

        if (inputActionReference.action.triggered)
        {
            Debug.Log("Button Pushed");
        }
        
    }
}
