using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ChangeFloat : ScriptableObject
{

    public float hightvalue;
    
    public void ChangeValue(float value)
    {
        hightvalue = value;
    }

}
