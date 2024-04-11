using UnityEngine;
using UnityEngine.Events;

public class SysetingContorller : MonoBehaviour
{
   public BoolData isActive;
   public UnityEvent isactiveEvent, isNotActiveEvent;
   
   public void SetCanvasActive()
   {

      if (isActive == true)
      {
         
         isactiveEvent.Invoke();
         
      }
      else 
      {
         
         isNotActiveEvent.Invoke();
         
      }
      
      
   }
   
}
