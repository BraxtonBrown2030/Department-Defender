using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public UnityEvent setFalse, setTrue;
    
    public bool onOff;

    public void SetBoolFalse()
    {

        onOff = false;
        setFalse.Invoke();

    }
    
    public void SetBoolTrue()
    {
        onOff = true;
        setTrue.Invoke();
    }
    
}
