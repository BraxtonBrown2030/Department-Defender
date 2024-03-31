using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "ScriptableObjects/IntData")]
public class IntData : ScriptableObject
{
  
    public int value;
    
    public void UpdateValue(int number)
    {
        value += number;
    }
    
}
