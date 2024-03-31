using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/ChangeFloat")]
public class ChangeFloat : ScriptableObject
{

    public float hightvalue;
    
    public void ChangeValue(float value)
    {
        hightvalue = value;
    }

}
