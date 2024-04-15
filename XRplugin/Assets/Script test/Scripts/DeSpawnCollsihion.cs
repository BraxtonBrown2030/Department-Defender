using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnCollsihion : MonoBehaviour
{

    public IEnumerator TimedDestroy()
    {

        yield return new WaitForSeconds(5);
        Destroy(gameObject);
        
    }

    public void OnDestroy()
    {
        StartCoroutine(TimedDestroy());
    }
}
