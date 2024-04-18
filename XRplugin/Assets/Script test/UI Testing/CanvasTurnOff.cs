using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CanvasTurnOff : MonoBehaviour
{
    public Canvas canvas;
    public UnityEvent turnOffEvent;

    public void Awake()
    {
        turnOffEvent.Invoke();
    }

    public IEnumerator DestroyAfterDelayCoroutine()
    {
        yield return new WaitForSeconds(15f);
            canvas.enabled = false;
    }
    
    public void DestroyAfterDelay()
    {
        StartCoroutine(DestroyAfterDelayCoroutine());
    }
}
