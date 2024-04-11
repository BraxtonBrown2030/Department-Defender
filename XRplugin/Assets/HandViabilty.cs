using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandViabilty : MonoBehaviour
{
    public GameObject leftclone;
    public GameObject  rightclone;

    public void Update()
    {
        leftclone = GameObject.Find("LeftHand(Clone)");
        rightclone = GameObject.Find("RightHand(Clone)");
        
    }

    public void ShowHandLeft()
    {
        MeshRenderer meshRenderer = leftclone.GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.enabled = true;
        }
    }

    public void HideHandLeft()
    {
        MeshRenderer meshRenderer = leftclone.GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.enabled = false;
        }
    }
    
    public void ShowHandRight()
    {
        MeshRenderer meshRenderer = rightclone.GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.enabled = true;
        }
    }  
    public void HideHandRight()
    {
        MeshRenderer meshRenderer = rightclone.GetComponent<MeshRenderer>();
        if (meshRenderer != null)
        {
            meshRenderer.enabled = false;
        }
    }
}
