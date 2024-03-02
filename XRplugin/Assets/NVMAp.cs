using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

[CreateAssetMenu]
public class NVMAp : ScriptableObject
{
    public NavMeshData navMeshData;
    public UnityEvent changeevent;
    
    public void ChangeNavMap()
    {
        
        changeevent.Invoke();    
        NavMesh.RemoveAllNavMeshData();
        NavMesh.AddNavMeshData(navMeshData);
        
    }
    
}
