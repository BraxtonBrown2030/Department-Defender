using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PlayerFollower : MonoBehaviour
{
    public XROrigin moveProvider;
    public Vector3Data playerPosition;

    public void Update()
    {
        
            playerPosition.value = moveProvider.gameObject.transform.position;
        
    }
}
