using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoDestroryBehavior : MonoBehaviour
{

    public IEnumerator DestroyAfterDelayCoroutine(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(2.5f);
        if (objectToDestroy != null)
        {
            Destroy(objectToDestroy);
        }
    }
    
    public void DestroyAfterDelay(GameObject objectToDestroy)
    {
        StartCoroutine(DestroyAfterDelayCoroutine(objectToDestroy));
    }
    
}
