using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeSpawnCollsihion : MonoBehaviour
{

    public IEnumerator TimedDestroy()
    {

        yield return new WaitForSeconds(1.5f);
        Destroy(gameObject);
        
    }

    public void OnDestroy()
    {
        StartCoroutine(TimedDestroy());
    }
}
