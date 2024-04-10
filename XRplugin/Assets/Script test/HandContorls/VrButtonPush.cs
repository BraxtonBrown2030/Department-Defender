using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;
public class VrButtonPush : MonoBehaviour
{
    [Tooltip("this is for the input action reference this can be found under the action map and look like bolt of lightning in a ball")]
    public InputActionReference inputAction; // This is the input action reference
    
    [Tooltip("This is the vr movment provider that is used to influence the xr origin rig can be found by searching for ActionBasedContinuousMoveProvider in the project search bar")]
    public ActionBasedContinuousMoveProvider moveProvider; // uses preinstalled action map to chamge default movement speed
    
    [Tooltip("this is the sprint speed of the movement in in movesprovider")]
    public float maxspeed;
    
    [Tooltip("This is the normal speed of the movement in in movesprovider")]
    public float minspeed;
    
    
    void Start()
    {
        moveProvider.moveSpeed = minspeed; // This is the speed of the movement in in movesprovider
        
    }
    
    void Update()
    {

        if (inputAction.action.ReadValue<float>() > 0.1f)
        {
           moveProvider.moveSpeed = maxspeed; // This is the sprint speed of the movement in in movesprovider

        }
        else
        {
           
            moveProvider.moveSpeed = minspeed; // This is the  walk speed of the movement in in movesprovider
           
        }
        
    }
}
