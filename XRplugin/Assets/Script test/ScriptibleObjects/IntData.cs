using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "ScriptableObjects/IntData")]
public class IntData : ScriptableObject
{
  
    public int value;
    public FloatData floatValue;
    
    public void UpdateValue(int number)
    {
        if (floatValue.value >= 100)
        {
            value += number;
        }
    }

    public void HealthSet(int number)
    {
        
        value += number;
        
    }
    
}
