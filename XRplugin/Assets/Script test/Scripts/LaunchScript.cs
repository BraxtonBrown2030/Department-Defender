using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchScript : MonoBehaviour
{
    public float launchSpeed = 10f;
    private BoxCollider boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    public void Launch()
    {
        // Move the object upwards and backwards over time
        StartCoroutine(LaunchCoroutine());
    }

    private IEnumerator LaunchCoroutine()
    {
        for (float t = 0; t < 1; t += Time.deltaTime / launchSpeed)
        {
            // Calculate the new position
            Vector3 newPosition = transform.position + (Vector3.up + Vector3.back) * (Time.deltaTime * launchSpeed);

            // Update the position of the object
            transform.position = newPosition;

            yield return null;
        }
    }
    
}
