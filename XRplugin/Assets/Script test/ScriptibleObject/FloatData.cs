using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu (menuName = "ScriptableObjects/FloatData")]
public class FloatData : ScriptableObject
{
  
    public float value;
    public UnityEvent changeEvent;
    
    
    public void UpdateValue(float number)
    {
        value += number;
        changeEvent.Invoke();
    }
    
}
