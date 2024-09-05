using UnityEngine;

public class MoveCanvas : MonoBehaviour
{
    public Canvas canvas;
    
    public Vector3 position1;
    public Vector3 potation2;
    
    
    public void MoveCanvasToPosition1()
    {
        
        canvas.transform.position = position1;
        
    }
    
    public void MoveCanvasToPosition2()
    {
        
        canvas.transform.position = potation2;
        
    }
    
    public void CanvasEnable()
    {
        
        canvas.enabled = true;
        
    }
    
    public void CanvasDisable()
    {
        
        canvas.enabled = false;
        
    }
    
}
