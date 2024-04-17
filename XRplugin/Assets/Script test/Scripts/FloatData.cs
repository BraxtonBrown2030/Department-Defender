using UnityEngine;
using System.Collections;

[CreateAssetMenu (menuName = "ScriptableObjects/FloatData")]
public class FloatData : ScriptableObject
{
  
    public float value;
    
    public void UpdateValue(float number)
    {
        value += number;
    }  
    public IEnumerator UpdateValue(float number, float delay)
    {
        yield return new WaitForSeconds(delay);
        value += number;
    }
    
    public void SetValue(float number)
    {
        value = number;
    }
    
}
