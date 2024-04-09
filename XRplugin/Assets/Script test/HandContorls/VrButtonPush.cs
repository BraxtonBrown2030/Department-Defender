using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class VrButtonPush : MonoBehaviour
{
    
    public InputActionReference inputAction; // This is the input action reference
    public ActionBasedContinuousMoveProvider moveProvider; // uses preinstalled action map to chamge default movement speed
    
    void Start()
    {
        moveProvider.moveSpeed = 1; // This is the speed of the movement in in movesprovider
        
    }
    
    void Update()
    {

        if (inputAction.action.ReadValue<float>() > 0.1f)
        {
           // moveProvider.moveSpeed = 4; // This is the sprint speed of the movement in in movesprovider

           Debug.Log("Button is pressed");

        }
        else
        {
           // moveProvider.moveSpeed = 1; // This is the  walk speed of the movement in in movesprovider
           
           Debug.Log("Button is not pressed");
           
        }
        
    }
}
