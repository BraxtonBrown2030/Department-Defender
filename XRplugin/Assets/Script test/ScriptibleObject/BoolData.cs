using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public UnityEvent setFalse;
    
    public bool onOff;

    public void SetBoolFalse()
    {

        onOff = false;
        setFalse.Invoke();

    }
    
}
